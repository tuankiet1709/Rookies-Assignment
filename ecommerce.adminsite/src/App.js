import React, { lazy, Suspense, useEffect } from "react";
import logo from "./logo.svg";
import "./App.css";
import Home from "./components/Home/Home";
import Layout from "./components/Navbar";
import Contact from "./components/Contact";
import { BrowserRouter,Route, Routes, Link,HashRouter } from "react-router-dom";
import InLineLoader from "./shared-components/InlineLoader.js";
import { PRODUCT } from "./Constants/pages";
import { BRAND } from "./Constants/pages";
import { Navbar } from "react-bootstrap";



const Product = lazy(() => import('./components/Product'));
const Brand = lazy(() => import('./components/Brand'));


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
          <Route path="*" element={<h2>404</h2>} />
        </Route>
      </Routes>

          
    </div>
  );
}
