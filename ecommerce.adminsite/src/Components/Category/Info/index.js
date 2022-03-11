import React from "react";
import { Modal, } from "react-bootstrap";

import {
  CheckIsShowOnHome,
  CheckIsShowOnHomeLabel,
  CheckIsNotShowOnHomeLabel,
} from "../../../Constants/Category/CategoryConstants";
import {
  CheckActive,
  CheckActiveLabel,
  CheckInActiveLabel,
} from "../../../Constants/Category/CategoryConstants";
import { get } from "../../../httpHelper";

const Info = ({ category, handleClose }) => {
  const getIsShowOnHomeCategory = (id) => {
    return id == CheckIsShowOnHome ? CheckIsShowOnHomeLabel : CheckIsNotShowOnHomeLabel;
  }
  const getIsActive = (id) => {
    return id == CheckActive ? CheckActiveLabel : CheckInActiveLabel;
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
            Detailed Category Infomation
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <div>
            <div className='row -intro-y'>
              <div className='col-4'>Id:</div>
              <div>{category.id}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Name:</div>
              <div>{category.name}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Description:</div>
              <div>{category.description}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Created Date:</div>
              <div>{getFormatDateTime(category.createdDate)}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Updated Date:</div>
              <div>{getFormatDateTime(category.updatedDate)}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Is Show On Home:</div>
              <div>{getIsShowOnHomeCategory(category.isShowOnHome)}</div>
            </div>

            <div className='row -intro-y'>
              <div className='col-4'>Is Show On Home:</div>
              <div>{getIsActive(category.status)}</div>
            </div>


          </div>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;