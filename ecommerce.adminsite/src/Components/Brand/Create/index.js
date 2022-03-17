import React, { useState } from "react";

import BrandFormContainer from "../BrandForm";

const CreateBrandContainer = () => {

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className="text-center">Create New Brand</h2>
      <br/>
      <div className='row'>
        <BrandFormContainer />
      </div>
    </div>
  );
};

export default CreateBrandContainer;
