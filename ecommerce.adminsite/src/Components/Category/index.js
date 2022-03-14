import React, { lazy } from 'react';
import { Route, Routes } from 'react-router-dom';

import { CREATE_CATEGORY, EDIT_CATEGORY } from '../../Constants/pages';

const CreateCategory = lazy(() => import("./Create"));
const ListCategory = lazy(() => import("./List"));
const UpdateCategory = lazy(() => import("./Update"))

const Category = () => {
    return (
    <Routes>
        <Route index
            element={<ListCategory />} 
        />
        <Route 
            path={CREATE_CATEGORY}
            element={<CreateCategory />} 
        />
        <Route 
            path={EDIT_CATEGORY}
            element={<UpdateCategory />} 
        />
    </Routes>
    )
};

export default Category;