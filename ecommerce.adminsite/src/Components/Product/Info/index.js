import React from "react";
import { Modal, } from "react-bootstrap";

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
    return id == CheckIsFeatured ? CheckIsFeaturedLabel : CheckIsNotFeaturedLabel;
  }

  const getIsDeleted = (id) => {
    return id == CheckIsDeleted ? CheckIsDeletedLabel : CheckIsNotDeletedLabel;
  }

  const getFormatDateTime=(date)=>{
    const DATE_OPTIONS = { weekday: 'short', year: 'numeric', month: 'short', day: 'numeric' };
    return new Date(date).toLocaleDateString('en-US', DATE_OPTIONS);
  }

  return (
    <>
      <Modal
        show={true}
        onHide={handleClose}
        dialogClassName="modal-90w"
      >
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Product Infomation
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <div>
            <div className='row -intro-y'>
              <div>Id: <span>{product.id}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Name: <span>{product.name}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Description:<span>{product.description}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Details: <span>{product.details}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Images: <span>{product.images}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Price: <span>{product.price}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Created Date: <span>{getFormatDateTime(product.createdDate)}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Updated Date: <span>{product.updatedDate==null?product.updatedDate:getFormatDateTime(product.updatedDate)}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Is Featured: <span>{getIsFeaturedProduct(product.isFeatured)}</span></div>
            </div>

            <div className='row -intro-y'>
              <div>Is Deleted: <span>{getIsDeleted(product.isDeleted)}</span></div>
            </div>


          </div>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;