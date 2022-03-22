import React from "react";
import { Modal } from "react-bootstrap";

import {
  CheckIsFeatured,
  CheckIsFeaturedLabel,
  CheckIsNotFeaturedLabel,
  CheckIsDeleted,
  CheckIsDeletedLabel,
  CheckIsNotDeletedLabel,
} from "../../../Constants/Product/ProductConstants";
import { get } from "../../../httpHelper";

const Info = ({ product, handleClose }) => {
  const getIsFeaturedProduct = (id) => {
    return id == CheckIsFeatured
      ? CheckIsFeaturedLabel
      : CheckIsNotFeaturedLabel;
  };

  const getIsDeleted = (id) => {
    return id == CheckIsDeleted ? CheckIsDeletedLabel : CheckIsNotDeletedLabel;
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
      <Modal show={true} onHide={handleClose} size="xl">
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Product Information
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
                <td className="col-md-10">{product.id}</td>
              </tr>
              <tr>
                <th scope="row">Name:</th>
                <td>{product.name}</td>
              </tr>
              <tr>
                <th scope="row">Description:</th>
                <td>{product.description}</td>
              </tr>
              <tr>
                <th scope="row">Details:</th>
                <td>{product.details}</td>
              </tr>
              <tr>
                <th scope="row">Created Date:</th>
                <td>{getFormatDateTime(product.createdDate)}</td>
              </tr>
              <tr>
                <th scope="row">Updated Date:</th>
                <td>
                  {product.updatedDate == null
                    ? product.updatedDate
                    : getFormatDateTime(product.updatedDate)}
                </td>
              </tr>
              <tr>
                <th scope="row">Price:</th>
                <td>{product.price}</td>
              </tr>
              <tr>
                <th scope="row">Is Deleted:</th>
                <td>{getIsDeleted(product.isDeleted)}</td>
              </tr>
              <tr>
                <th scope="row">Images:</th>
                <td>
                  <img src={product.images} alt="Product Image"
                    className="object-center w-full rounded-md"
                  />
                </td>
                  
              </tr>
            </tbody>
          </table>
        </Modal.Body>
      </Modal>
    </>
  );
};

export default Info;
