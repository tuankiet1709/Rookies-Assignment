import React, { lazy, Suspense, useEffect } from "react";
import logo from "./logo.svg";
import "./App.css";
import Home from "./Components/Home/Home";
import Layout from "./Components/Navbar";
import Contact from "./Components/Contact";
import { BrowserRouter,Route, Routes, Link } from "react-router-dom";
import InLineLoader from "./Shared-Components/InlineLoader.js";
import { PRODUCT } from "./Constants/pages";

const Product = React.lazy(() => import('./Components/Product'));

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
          <Route path="contact" element={<Contact />} />
          <Route 
          path={PRODUCT} 
          element={
            <Suspense fallback={<>...</>}>
              <Product />
            </Suspense>}/>
          <Route path="*" element={<h2>404</h2>} />
        </Route>
      </Routes>
    </div>
  );
}

