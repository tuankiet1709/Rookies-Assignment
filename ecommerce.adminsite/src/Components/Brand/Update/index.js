import React, { useEffect, useState } from 'react'
import { Redirect, useParams, useLocation } from 'react-router';

import BrandForm from '../BrandForm';

const UpdateBrandContainer = () => {
  const [brand, setBrand] = useState(undefined);
  const {state} = useLocation();
  const { existBrand } = state; // Read values passed on state
  
  useEffect(() => {
    if (existBrand) {
      setBrand({
        id: existBrand.id,
        name: existBrand.name,
        type: existBrand.type,
        imagePath: existBrand.imagePath,
        imageFile: existBrand.imageFile
      });
    }
  }, [existBrand]);

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className='text-center'>Update Brand {existBrand?.brandName}</h2>
      <br/>
      <div className='row'>
        {
          brand && (<BrandForm
            initialBrandForm={brand}
  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateBrandContainer;
