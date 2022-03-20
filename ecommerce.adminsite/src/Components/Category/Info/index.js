import React from "react";
import { Modal } from "react-bootstrap";

import {
  CheckIsShowOnHome,
  CheckIsShowOnHomeLabel,
  CheckIsNotShowOnHomeLabel,
} from "../../../Constants/Category-Brand/CategoryBrandConstants";
import {
  CheckActive,
  CheckActiveLabel,
  CheckInActiveLabel,
} from "../../../Constants/Category-Brand/CategoryBrandConstants";

const Info = ({ category, handleClose }) => {
  const getIsShowOnHomeCategory = (id) => {
    return id == CheckIsShowOnHome
      ? CheckIsShowOnHomeLabel
      : CheckIsNotShowOnHomeLabel;
  };
  const getIsActive = (id) => {
    return id == CheckActive ? CheckActiveLabel : CheckInActiveLabel;
  };
  const getFormatDateTime = (date) => {
    const DATE_OPTIONS = {
      weekday: "short",
      year: "numeric",
      month: "short",
      day: "numeric",
    };
    return new Date(date).toLocaleDateString("en-US", DATE_OPTIONS);
  };

  return (
    <>
      <Modal show={true} onHide={handleClose} dialogClassName="" size="xl">
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Category Information
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <table className="table table-borderless container-fluid">
            <thead>
              <tr className="d-flex">
                <th scope="col" className="col-md-2"></th>
                <th scope="col" className="col-md-10"></th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <th scope="row" className="col-md-2">Id:</th>
                <td className="col-md-10">{category.id}</td>
              </tr>
              <tr>
                <th scope="row">Name:</th>
                <td>{category.name}</td>
              </tr>
              <tr>
                <th scope="row">Description:</th>
                <td>{category.description}</td>
              </tr>
              <tr>
                <th scope="row">Created Date:</th>
                <td>{getFormatDateTime(category.createdDate)}</td>
              </tr>
              <tr>
                <th scope="row">Updated Date:</th>
                <td>
                  {category.updatedDate == null
                    ? category.updatedDate
                    : getFormatDateTime(category.updatedDate)}
                </td>
              </tr>
              <tr>
                <th scope="row">Is show on home:</th>
                <td>{getIsShowOnHomeCategory(category.isShowOnHome)}</td>
              </tr>
              <tr>
                <th scope="row">Status:</th>
                <td>{getIsActive(category.status)}</td>
              </tr>
            </tbody>
          </table>
        </Modal.Body>
      </Modal>
    </>
  );
};

export default Info;
