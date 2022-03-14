import React, { useState } from "react";
import { PencilFill, XCircle } from "react-bootstrap-icons";
import { useNavigate } from "react-router";
import ButtonIcon from "../../../shared-components/ButtonIcon";
import { NotificationManager } from 'react-notifications';

import Table, { SortType } from "../../../shared-components/Table";
import Info from "../Info";
import { EDIT_PRODUCT_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../shared-components/ConfirmModal";
import { 
  CheckIsFeatured,
  CheckIsFeaturedLabel,
  CheckIsNotFeaturedLabel,
  CheckIsDeleted,
  CheckIsDeletedLabel,
  CheckIsNotDeletedLabel
} from "../../../Constants/Product/ProductConstants";
import { DisableProductRequest } from "../services/request"

const columns= [
  { columnName: "id ", columnValue: "Id" },
  { columnName: "name ", columnValue: "Name" },
  { columnName: "description ", columnValue: "Description" },
  { columnName: "details ", columnValue: "Details" },
  { columnName: "images ", columnValue: "Images" },
  { columnName: "originalPrice ", columnValue: "OriginalPrice" },
  { columnName: "price ", columnValue: "Price" },
  { columnName: "created Date ", columnValue: "CreatedDate" },
  { columnName: "updated Date ", columnValue: "UpdatedDate" }, 
  { columnName: "category Id ", columnValue: "CategoryId" }, 
  { columnName: "isFeatured ", columnValue: "IsFeatured" }, 
  { columnName: "isDeleted ", columnValue: "IsDeleted" }, 
];

const ProductTable = ({
  products,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [productDetail, setProductDetail] = useState(null);
  const [disableState, setDisable] = useState({
    isOpen: false,
    id: 0,
    title: '',
    message: '',
    isDisable: true,
  });

  const handleShowInfo = (id) => {
    const product = products?.items.find((item) => item.id === id);

    if (product) {
      setProductDetail(product);
      setShowDetail(true);
    }
  };

  const getIsFeatured = (id) => {
    return id == CheckIsFeatured ? CheckIsFeaturedLabel : CheckIsNotFeaturedLabel;
  }

  const getIsDeleted = (id) => {
    return id == CheckIsDeleted ? CheckIsDeletedLabel : CheckIsNotDeletedLabel;
  }

  const getFormatDateTime=(date)=>{
    const DATE_OPTIONS = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
    return new Date(date).toLocaleDateString('en-US', DATE_OPTIONS);
  }

  const handleShowDisable = async (id) => {
    setDisable({
      id,
      isOpen: true,
      title: 'Are you sure',
      message: 'Do you want to disable this Products?',
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
        `Remove Product Successful`,
        `Remove Successful`,
        2000,
    );
    } else {
      setDisable({
        ...disableState,
        title: 'Can not disable Product',
        message,
        isDisable: result
      });
    }
  };
    
  const handleConfirmDisable = async () => {
    let isSuccess = await DisableProductRequest(disableState.id);
    if (isSuccess) {
      await handleResult(true, '');
    }
  };

  const handleCloseDetail = () => {
    setShowDetail(false);
  };

  const navigate = useNavigate();
  const handleEdit = (id) => {
    const existProduct = products?.items.find(item => item.id === Number(id));
    navigate(
      EDIT_PRODUCT_ID(id),
      {
        state:{existProduct: existProduct}
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
          currentPage: products?.currentPage,
          totalPage: products?.totalPages,
          handleChange: handlePage,
        }}
      >
        {products && products?.items?.map((data, index) => (
          <tr key={index} className="" onClick={() => handleShowInfo(data.id)}>
            <td>{data.name}</td>
            <td>{data.description}</td>
            <td>{data.details}</td>
            <td>{data.images}</td>
            <td>{data.originalPrice}</td>
            <td>{data.price}</td>
            <td>{getFormatDateTime(data.createdDate)}</td>
            <td>{data.updatedDate==null?data.updatedDate:getFormatDateTime(data.updatedDate)}</td>
            <td>{data.categoryId}</td>
            <td>{getIsFeatured(data.isFeatured)}</td>
            <td>{getIsDeleted(data.isDeleted)}</td>

            <td className="d-flex">
              <ButtonIcon onClick={() => handleEdit(data.id)}>
                <PencilFill className="text-black" />
              </ButtonIcon>
              <ButtonIcon onClick={() => handleShowDisable(data.id)}>
                <XCircle className="text-danger mx-2" />
              </ButtonIcon>
            </td>
          </tr>
        ))}
      </Table>
      {productDetail && showDetail && (
        <Info product={productDetail} handleClose={handleCloseDetail} />
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

export default ProductTable;
