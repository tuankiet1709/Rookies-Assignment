import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router';

import ProductForm from '../ProductForm';

const UpdateProductContainer = () => {
  const [product, setProduct] = useState(undefined);
  const {state} = useLocation();
  const { existProduct } = state; // Read values passed on state
  
  useEffect(() => {
    if (existProduct) {
      setProduct({
        id:existProduct.id,
        name: existProduct.name,
        description: existProduct.description,
        details: existProduct.details,
        originalPrice: existProduct.originalPrice,
        price: existProduct.price,
        updatedDate: existProduct.updatedDate,
        isFeatured: existProduct.isFeatured,
        categoryId: existProduct.categoryId,
        brandId: existProduct.brandId,
        imageFile:existProduct.images,
      });
    }
  }, [existProduct]);

  return (
    <div className='ml-5'>
      <div className='primaryColor text-title intro-x'>
        Update Product {existProduct?.name}
      </div>

      <div className='row'>
        {
          product && (<ProductForm
            initialProductForm={product}
  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateProductContainer;
