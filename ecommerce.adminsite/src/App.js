import React, { lazy } from "react";
import "./App.css";
import Home from "./components/Home/Home";
import Navbar from "./components/Navbar";
import { Route, Routes } from "react-router-dom";
import { PRODUCT } from "./Constants/pages";
import { BRAND } from "./Constants/pages";
import { CATEGORY } from "./Constants/pages";
import { CUSTOMER } from "./Constants/pages";


const Product = lazy(() => import('./components/Product'));
const Brand = lazy(() => import('./components/Brand'));
const Category = lazy(() => import('./components/Category'));
const Customer = lazy(() => import('./components/Customer'));


export default function App() {
  return (
    <>
      <Routes>
        <Route path="/" element={<Navbar />}>
          <Route index element={<Home />} />
          <Route
            path={BRAND}
            element={
              <React.Suspense fallback={<>...</>}>
                <Brand />
              </React.Suspense>
            }
          />
          <Route
            path={PRODUCT}
            element={
              <React.Suspense fallback={<>...</>}>
                <Product />
              </React.Suspense>
            }
          />
          <Route
            path={CATEGORY}
            element={
              <React.Suspense fallback={<>...</>}>
                <Category />
              </React.Suspense>
            }
            />
          <Route
            path={CUSTOMER}
            element={
              <React.Suspense fallback={<>...</>}>
                <Customer />
              </React.Suspense>
            }
            />
            <Route path="*" element={<h2>404</h2>} />
        </Route>
      </Routes>


    </>
  );
}
