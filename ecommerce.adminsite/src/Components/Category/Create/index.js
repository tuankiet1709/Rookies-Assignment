import React, { useState } from "react";

import CategoryFormContainer from "../CategoryForm";

const CreateCategoryContainer = () => {

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className="text-center">Create New Category</h2>
      <br/>
      <div className='row'>
        <CategoryFormContainer />
      </div>
    </div>
  );
};

export default CreateCategoryContainer;
