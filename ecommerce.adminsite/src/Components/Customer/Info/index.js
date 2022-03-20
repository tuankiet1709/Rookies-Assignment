import React from "react";
import { Modal } from "react-bootstrap";

import { get } from "../../../httpHelper";

const Info = ({ customer, handleClose }) => {
  return (
    <>
      <Modal show={true} onHide={handleClose} size="xl">
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Customer Information
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
                <td className="col-md-10">{customer.id}</td>
              </tr>
              <tr>
                <th scope="row">First Name:</th>
                <td>{customer.firstName}</td>
              </tr>
              <tr>
                <th scope="row">Last Name:</th>
                <td>{customer.lastName}</td>
              </tr>
              <tr>
                <th scope="row">UserName:</th>
                <td>{customer.userName}</td>
              </tr>
              <tr>
                <th scope="row">Email:</th>
                <td>{customer.email}</td>
              </tr>
              <tr>
                <th scope="row">Phone Number:</th>
                <td>{customer.phoneNumber}</td>
              </tr>
            </tbody>
          </table>
        </Modal.Body>
      </Modal>
    </>
  );
};

export default Info;
