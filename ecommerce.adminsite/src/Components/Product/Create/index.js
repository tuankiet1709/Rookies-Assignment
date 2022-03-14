import React, { useState } from "react";

import ProductFormContainer from "../ProductForm";

const CreateProductContainer = () => {

  return (
    <div className='ml-5'>
      <div className='primaryColor text-title intro-x'>
        Create New Product
      </div>

      <div className='row'>
        <ProductFormContainer />

      </div>

    </div>
  );
};

export default CreateProductContainer;
