import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router';

import CategoryForm from '../CategoryForm';

const UpdateCategoryContainer = () => {
  const [category, setCategory] = useState(undefined);
  const {state} = useLocation();
  const { existCategory } = state; // Read values passed on state
  
  useEffect(() => {
    if (existCategory) {
      setCategory({
        id: existCategory.id,
        name: existCategory.name,
        description: existCategory.description,
        isShowOnHome: existCategory.isShowOnHome,
      });
    }
  }, [existCategory]);

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className='text-center'>Update Category {existCategory?.name}</h2>
      <br/>
      <div className='row'>
        {
          category && (<CategoryForm
            initialCategoryForm={category}
  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateCategoryContainer;
