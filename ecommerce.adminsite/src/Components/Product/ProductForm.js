import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useNavigate } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../shared-components/FormInputs/TextField';
import SelectField from '../../shared-components/FormInputs/SelectField';
import FileUpload from '../../shared-components/FormInputs/FileUpload';
import { PRODUCT } from '../../Constants/pages';
import { isFeaturedProductOptions } from '../../Constants/selectOptions';
import { createProductRequest, UpdateProductRequest } from "./services/request";
import { getCategoriesOptionRequest } from '../Category/services/request';
import { getBrandsOptionRequest } from '../Brand/services/request';

const initialFormValues = {
    name: '',
    description: '',
    details: '',
    originalPrice: '',
    price: '',
    isFeatured: '',
    categoryId: '',
    brandId:'',
    images:'',

};

const validationSchema = Yup.object().shape({
    name: Yup.string().required('Required'),
    description: Yup.string().required('Required'),
    details: Yup.string().required('Required'),
    originalPrice: Yup.string().required('Required'),
    price: Yup.string().required('Required'),
    isFeatured: Yup.string().required('Required'),
    categoryId: Yup.string().required('Required'),
    brandId: Yup.string().required('Required'),
});

const ProductFormContainer = ({ initialProductForm = {
    ...initialFormValues
} }) => {
    const [loading, setLoading] = useState(false);
    const [selectCategoryOption, setSelectCategoryOptions] = useState([]);
    const [selectBrandOptions, setSelectBrandOptions] = useState([]);

    const isUpdate = initialProductForm.id ? true : false;

    const navigate = useNavigate();

    useEffect(() => {
        async function fetchDataAsync() {
          let categoryResult = await getCategoriesOptionRequest("child");
          let brandResult = await getBrandsOptionRequest();
          setSelectCategoryOptions(categoryResult.data);
          setSelectBrandOptions(brandResult.data);
        }
        
        fetchDataAsync();
      }, []);


    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Product ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                navigate(PRODUCT);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateProductAsync = async (form) => {
        console.log('update product async');
        let data = await UpdateProductRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    const createProductAsync = async (form) => {  
        console.log('create product async');
        let data = await createProductRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    return (
        <Formik
            initialValues={initialProductForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateProductAsync({ formValues: values });
                    }
                    else {
                        createProductAsync({ formValues: values });
                    }

                    setLoading(false);
                }, 1000);
            }}
        >
            {(actions) => (
                <Form className='intro-y col-lg-6 col-12'>
                    <TextField 
                        name="name" 
                        label="Name" 
                        placeholder="input product name" 
                        isrequired  />
                    <TextField 
                        name="description" 
                        label="Description" 
                        placeholder="input product description" 
                        isrequired  />
                    <TextField 
                        name="details" 
                        label="Details" 
                        placeholder="input product details" 
                        isrequired  />
                    <TextField 
                        name="originalPrice" 
                        label="Original Price" 
                        placeholder="input product original price" 
                        isrequired  />
                    <TextField 
                        name="price" 
                        label="Price" 
                        placeholder="input product price" 
                        isrequired  />
                     <SelectField 
                        name="isFeatured" 
                        label="IsFeatured" 
                        options={isFeaturedProductOptions}
                        isrequired  />
                    <SelectField 
                        name="categoryId" 
                        label="CategoryId" 
                        options={
                            selectCategoryOption.map((item) => {
                            return ({id:item.id, label: item.name, value: item.id })
                          })}/>
                    <SelectField 
                        name="brandId" 
                        label="BrandId" 
                        options={
                            selectBrandOptions.map((item) => {
                            return ({id:item.id, label: item.name, value: item.id })
                          })}/>
                    <FileUpload 
                        name="imageFile" 
                        label="Image" 
                        image={actions.values.imagePath} />
                    

                    <div className="d-flex">
                        <div className="ml-auto">
                            <button className="btn btn-danger"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>

                            <Link to={ PRODUCT } className="btn btn-outline-secondary ml-2">
                                Cancel
                            </Link>
                        </div>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default ProductFormContainer;
