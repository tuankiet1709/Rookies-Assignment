import React, { useEffect, useState } from "react";
import SearchIcon from '@material-ui/icons/Search';

import { Link } from "react-router-dom";
import CustomerTable from "./CustomerTable";

import { getCustomersRequest } from "../services/request"
import { 
  ACCSENDING, 
  DECSENDING, 
  DEFAULT_CUSTOMER_SORT_COLUMN_NAME,
  DEFAULT_PAGE_LIMIT
} from "../../../Constants/paging"

const ListCustomer = () => {

  const [query, setQuery] = useState({
    page: 1,
    limit: DEFAULT_PAGE_LIMIT,
    sortOrder: ACCSENDING,
    sortColumn: DEFAULT_CUSTOMER_SORT_COLUMN_NAME
  });

  const [search, setSearch] = useState("");
  const [customers, setCustomers] = useState("");

  const handleChangeSearch = (e) => {
    e.preventDefault();

    const search = e.target.value;
    setSearch(search);
  };

  const handlePage = (page) => {
    setQuery({
      ...query,
      page,
    });
  };

  const handleSearch = () => {
    setQuery({
      ...query,
      search,
    });
  };

  const handleSort = (sortColumn) => {
    const sortOrder = query.sortOrder === ACCSENDING ? DECSENDING : ACCSENDING;

    setQuery({
      ...query,
      sortColumn,
      sortOrder,
    });
  };

  const fetchDataCallbackAsync = async () =>  {
    let data = await getCustomersRequest(query);
    console.log('fetchDataCallbackAsync');
    console.log(data);
    setCustomers(data);
  }

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getCustomersRequest(query);
      setCustomers(result.data);
    }

    fetchDataAsync();
  }, [query, customers]);

  return (
    <>
      <div className="container-fluid"> 
      
        <div className="d-flex intro-x">
          <div className="me-auto p-2 bd-highlight w-50 fs-2">Customer List</div>

          <div className="d-flex align-items-center">
            <div className="input-group search-margin">
            <div >
              <div >
                  <div className="input-group">
                      <input className="form-control border" 
                            id="example-search-input"
                            onChange={handleChangeSearch}
                            value={search}
                            type="text"/>
                      <span onClick={handleSearch} className="input-group-append">
                          <button className="btn btn-outline-secondary bg-white border-start-0 border w-20" type="button">
                              <SearchIcon/>
                          </button>
                      </span>
                  </div>
              </div>
            </div>
              
            </div>
          </div>
        </div>

        <CustomerTable
          customers={customers}
          handlePage={handlePage}
          handleSort={handleSort}
          sortState={{
            columnValue: query.sortColumn,
            orderBy: query.sortOrder,
          }}
          fetchData={fetchDataCallbackAsync}
        />
      </div>
    </>
  );
};

export default ListCustomer;
