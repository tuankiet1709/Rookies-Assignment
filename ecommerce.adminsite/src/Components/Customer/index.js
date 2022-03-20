import React, { lazy } from 'react';
import { Route, Routes } from 'react-router-dom';

const ListCustomer = lazy(() => import("./List"));

const Customer = () => {
    return (
    <Routes>
        <Route index
            element={<ListCustomer />} 
        />
    </Routes>
    )
};

export default Customer;