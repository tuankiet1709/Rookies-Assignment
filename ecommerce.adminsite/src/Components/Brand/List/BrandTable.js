import React, { useState } from "react";
import DeleteIcon from '@material-ui/icons/Delete';
import EditIcon from '@material-ui/icons/Edit';
import { useNavigate } from "react-router";
import ButtonIcon from "../../../shared-components/ButtonIcon";
import { NotificationManager } from 'react-notifications';

import Table, { SortType } from "../../../shared-components/Table";
import Info from "../Info";
import { EDIT_BRAND_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../shared-components/ConfirmModal";
import {
  CheckIsShowOnHome,
  CheckIsShowOnHomeLabel,
  CheckIsNotShowOnHomeLabel,
  CheckActive,
  CheckActiveLabel,
  CheckInActiveLabel,
} from "../../../Constants/Category-Brand/CategoryBrandConstants";
import { DisableBrandRequest } from "../services/request"

const columns= [
  { columnName: "id", columnValue: "Id" },
  { columnName: "name", columnValue: "Name" },
  { columnName: "created Date ", columnValue: "CreatedDate" },
  { columnName: "updated Date ", columnValue: "UpdatedDate" }, 
  { columnName: "isShowOnHome ", columnValue: "IsShowOnHome" }, 
  { columnName: "is Active ", columnValue: "IsActive" }, 
];

const BrandTable = ({
  brands,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [brandDetail, setBrandDetail] = useState(null);
  const [disableState, setDisable] = useState({
    isOpen: false,
    id: 0,
    title: '',
    message: '',
    isDisable: true,
  });

  const handleShowInfo = (id) => {
    const brand = brands?.items.find((item) => item.id === id);

    if (brand) {
      setBrandDetail(brand);
      setShowDetail(true);
    }
  };

  const getFormatDateTime=(date)=>{
    const DATE_OPTIONS = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
    return new Date(date).toLocaleDateString('en-US', DATE_OPTIONS);
  };

  const getIsShowOnHome = (id) => {
    return id == CheckIsShowOnHome ? CheckIsShowOnHomeLabel : CheckIsNotShowOnHomeLabel;
  };

  const getIsActive = (id) => {
    return id == CheckActive ? CheckActiveLabel : CheckInActiveLabel;
  }

  const handleShowDisable = async (id) => {
    setDisable({
      id,
      isOpen: true,
      title: 'Are you sure',
      message: 'Do you want to disable this Brand?',
      isDisable: true,
    });
  };

  const handleCloseDisable = () => {
    setDisable({
      isOpen: false,
      id: 0,
      title: '',
      message: '',
      isDisable: true,
    });
  };

  const handleResult = async (result, message) => {
    if (result) {
      handleCloseDisable();
      await fetchData();
      NotificationManager.success(
        `Remove Brand Successful`,
        `Remove Successful`,
        2000,
    );
    } else {
      setDisable({
        ...disableState,
        title: 'Can not disable Brand',
        message,
        isDisable: result
      });
    }
  };
    
  const handleConfirmDisable = async () => {
    let isSuccess = await DisableBrandRequest(disableState.id);
    if (isSuccess) {
      await handleResult(true, '');
    }
  };

  const handleCloseDetail = () => {
    setShowDetail(false);
  };

  const navigate = useNavigate();
  const handleEdit = (id) => {
    const existBrand = brands?.items.find(item => item.id === Number(id));
    navigate(
      EDIT_BRAND_ID(id),
      {
        state: {existBrand: existBrand}
      }
    );
  };

  return (
    <>
      <Table
        columns={columns}
        handleSort={handleSort}
        sortState={sortState}
        page={{
          currentPage: brands?.currentPage,
          totalPage: brands?.totalPages,
          handleChange: handlePage,
        }}
      >
        {brands && brands?.items?.map((data, index) => (
          <tr key={index} className="" onClick={() => handleShowInfo(data.id)}>
            <td>{data.id}</td>
            <td>{data.name}</td>
            <td>{getFormatDateTime(data.createdDate)}</td>
            <td>{data.updatedDate==null?data.updatedDate:getFormatDateTime(data.updatedDate)}</td>
            <td>{getIsShowOnHome(data.isShowOnHome)}</td>
            <td>{getIsActive(data.status)}</td>

            <td>
              <div className="d-flex justify-content-center">
                  <ButtonIcon onClick={() => handleEdit(data.id)} className="btn btn-primary p-2">
                    <EditIcon fontSize="small" />
                  </ButtonIcon>
                  &#160;
                  <ButtonIcon onClick={() => handleShowDisable(data.id)} className="btn btn-danger p-2">
                    <DeleteIcon fontSize="small"/>
                  </ButtonIcon>
              </div>
            </td>
          </tr>
        ))}
      </Table>
      {brandDetail && showDetail && (
        <Info brand={brandDetail} handleClose={handleCloseDetail} />
      )}
      <ConfirmModal
        title={disableState.title}
        isShow={disableState.isOpen}
        onHide={handleCloseDisable}
      >
        <div>

          <div className="text-center">
            {disableState.message}
          </div>
          {
            disableState.isDisable && (
              <div className="text-center mt-3">
                <button
                  className="btn btn-danger mr-3"
                  onClick={handleConfirmDisable}
                  type="button"
                >
                  Disable
                </button>
                &ensp;
                <button
                  className="btn btn-outline-secondary"
                  onClick={handleCloseDisable}
                  type="button"
                >
                  Cancel
                </button>
              </div>
            )
          }
        </div>
      </ConfirmModal>
    </>
  );
};

export default BrandTable;
