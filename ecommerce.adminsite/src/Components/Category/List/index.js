import React, { useEffect, useState } from "react";
import SearchIcon from '@material-ui/icons/Search';
import '../Category.css';

import { Link } from "react-router-dom";
import CategoryTable from "./CategoryTable";

import { isShowOnHomeOptions } from "../../../Constants/selectOptions";

import { getCategoriesRequest } from "../services/request"
import { 
  ACCSENDING, 
  DECSENDING, 
  DEFAULT_CATEGORY_SORT_COLUMN_NAME,
  DEFAULT_PAGE_LIMIT
} from "../../../Constants/paging"

const ListCategory = () => {
  const [query, setQuery] = useState({
    page: 1,
    limit: DEFAULT_PAGE_LIMIT,
    sortOrder: ACCSENDING,
    sortColumn: DEFAULT_CATEGORY_SORT_COLUMN_NAME
  });

  const [search, setSearch] = useState("");
  const [categories, setCategories] = useState("");

  const [selectedType, setSelectedType] = useState([
    { id: 1, label: "All", value: 0 },
  ]);

  const handleType = (selected) => {
    if (selected.length === 0) {
      setQuery({
        ...query,
        types: [],
      });

      setSelectedType([isShowOnHomeOptions[0]]);
      return;
    }

    const selectedAll = selected.find((item) => item.id === 1);

    setSelectedType((prevSelected) => {
      if (!prevSelected.some((item) => item.id === 1) && selectedAll) {
        setQuery({
          ...query,
          types: [],
        });

        return [selectedAll];
      }

      const newSelected = selected.filter((item) => item.id !== 1);
      const types = newSelected.map((item) => item.value);

      setQuery({
        ...query,
        types,
      });

      return newSelected;
    });
  };

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
    let data = await getCategoriesRequest(query);
    console.log('fetchDataCallbackAsync');
    console.log(data);
    setCategories(data);
  }

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getCategoriesRequest(query);
      setCategories(result.data);
    }

    fetchDataAsync();
  }, [query, categories]);

  return (
    <>
      <div className="container-fluid"> 
        <div className="d-flex flex-row-reverse create-margin">
          <Link to="/category/create" type="button" className="btn btn-success">
            Create new Category
          </Link>
        </div>
        <div className="d-flex intro-x">
          <div class="me-auto p-2 bd-highlight w-50 fs-2">Category List</div>

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

        <CategoryTable
          categories={categories}
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

export default ListCategory;
