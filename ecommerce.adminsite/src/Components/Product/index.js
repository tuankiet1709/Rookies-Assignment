import React, { lazy } from 'react';
import { Route, Routes } from 'react-router-dom';

import { CREATE_PRODUCT, EDIT_PRODUCT } from '../../Constants/pages';

const CreateProduct = lazy(() => import("./Create"));
const ListProduct = lazy(() => import("./List"));
const UpdateProduct = lazy(() => import("./Update"))

const Product = () => {
    return (
    <Routes>
        <Route index
            element={<ListProduct />} 
        />
        <Route 
            path={CREATE_PRODUCT}
            element={<CreateProduct />} 
        />
        <Route 
            path={EDIT_PRODUCT}
            element={<UpdateProduct />} 
        />
    </Routes>
    )
};

export default Product;