import React, { lazy } from 'react';
import { Route, Routes } from 'react-router-dom';

import { CREATE_BRAND, EDIT_BRAND } from '../../Constants/pages';

const CreateBrand = lazy(() => import("./Create"));
const ListBrand = lazy(() => import("./List"));
const UpdateBrand = lazy(() => import("./Update"))

const Brand = () => {
    return (
        <Routes>
            <Route index
                element={<ListBrand />}
            />
            <Route path={CREATE_BRAND} 
                element={<CreateBrand />}
            />
            <Route path={EDIT_BRAND} 
                element={<UpdateBrand />}
            />
        </Routes>
    )
};

export default Brand;