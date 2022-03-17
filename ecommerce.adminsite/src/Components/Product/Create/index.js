import React, { useState } from "react";

import ProductFormContainer from "../ProductForm";

const CreateProductContainer = () => {

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className="text-center">
        Create New Product
      </h2>
      <br/>
      <div className='row'>
        <ProductFormContainer />
      </div>
    </div>
  );
};

export default CreateProductContainer;
