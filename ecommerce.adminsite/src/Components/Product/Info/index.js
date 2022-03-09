import React from "react";
import { Modal, } from "react-bootstrap";

import {
  Yes,
  No 
} from "../../../Constants/Product/ProductConstants";
import { get } from "../../../httpHelper";

const Info = ({ product, handleClose }) => {
  const getIsFeaturedProduct = (id) => {
    return id == true ? Yes : No;
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
              <div className='col-4'>Id:</div>
              <div>{product.id}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Name:</div>
              <div>{product.name}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Description:</div>
              <div>{product.description}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Detail:</div>
              <div>{product.detail}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>OriginPrice:</div>
              <div>{product.originPrice}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Price:</div>
              <div>{product.price}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>DescreasedPrice:</div>
              <div>{product.decreasedPrice}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Stock:</div>
              <div>{product.stock}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>View Count:</div>
              <div>{product.viewCount}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Is Featured:</div>
              <div>{getIsFeaturedProduct(product.isFeatured)}</div>
            </div>


          </div>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;