import React, { lazy, Suspense, useEffect } from "react";
import logo from "./logo.svg";
import "./App.css";
import Home from "./components/Home/Home";
import Layout from "./components/Navbar";
import Contact from "./components/Contact";
import { Route, Routes } from "react-router-dom";
import { PRODUCT } from "./Constants/pages";
import { BRAND } from "./Constants/pages";
import { CATEGORY } from "./Constants/pages";



const Product = lazy(() => import('./components/Product'));
const Brand = lazy(() => import('./components/Brand'));
const Category = lazy(() => import('./components/Category'));


export default function App() {
  return (
    <div>
      <h1>Basic Example</h1>

      <p>
        This example demonstrates some of the core features of React Router
        including nested <code>&lt;Route&gt;</code>s,{" "}
        <code>&lt;Outlet&gt;</code>s, <code>&lt;Link&gt;</code>s, and using a
        "*" route (aka "splat route") to render a "not found" page when someone
        visits an unrecognized URL.
      </p>

      <Routes>
        <Route path="/" element={<Layout />}>
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
          <Route path="*" element={<h2>404</h2>} />
        </Route>
      </Routes>

          
    </div>
  );
}
