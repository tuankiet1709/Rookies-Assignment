import React, { useState } from "react";

import Table from "../../../shared-components/Table";
import Info from "../Info";

const columns= [
  { columnName: "id ", columnValue: "Id" },
  { columnName: "firstName ", columnValue: "FirstName" },
  { columnName: "lastName ", columnValue: "LastName" },
  { columnName: "userName ", columnValue: "UserName" },
  { columnName: "email ", columnValue: "Email" },
  { columnName: "phoneNumber ", columnValue: "PhoneNumber" },
];

const CustomerTable = ({
  customers,
  handlePage,
  handleSort,
  sortState,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [customerDetail, setCustomerDetail] = useState(null);

  const handleShowInfo = (id) => {
    const customer = customers?.items.find((item) => item.id === id);

    if (customer) {
      setCustomerDetail(customer);
      setShowDetail(true);
    }
  };

  const handleCloseDetail = () => {
    setShowDetail(false);
  };

  return (
    <>
      <Table
        columns={columns}
        handleSort={handleSort}
        sortState={sortState}
        page={{
          currentPage: customers?.currentPage,
          totalPage: customers?.totalPages,
          handleChange: handlePage,
        }}
      >
        {customers && customers?.items?.map((data, index) => (
          <tr key={index} className="" onClick={() => handleShowInfo(data.id)}>
            <td>{data.id}</td>
            <td>{data.firstName}</td>
            <td>{data.lastName}</td>
            <td>{data.userName}</td>
            <td>{data.email}</td>
            <td>{data.phoneNumber}</td>
          </tr>
        ))}
      </Table>
      {customerDetail && showDetail && (
        <Info customer={customerDetail} handleClose={handleCloseDetail} />
      )}
    </>
  );
};

export default CustomerTable;
