import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useNavigate } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../Shared-Components/FormInputs/TextField';
import SelectField from '../../Shared-Components/FormInputs/SelectField';
import { PRODUCT } from '../../Constants/pages';
import { IsFeaturedProduct } from '../../selectOptions';
import { createProductRequest, UpdateProductRequest } from "./services/request";

const initialFormValues = {
    name: '',
    description: '',
    details: '',
    price: '',
    isFeatured: '',
};

const validationSchema = Yup.object().shape({
    name: Yup.string().required('Required'),
    type: Yup.string().required('Required')
});

const ProductFormContainer = ({ initialProductForm = {
    ...initialFormValues
} }) => {
    const [loading, setLoading] = useState(false);

    const isUpdate = initialProductForm.id ? true : false;

    const history = useNavigate();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Product ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                history.push(PRODUCT);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateProductAsync = async (form) => {
        console.log('update brand async');
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
                        isrequired 
                        disabled={isUpdate ? true : false} />
                    <TextField 
                        name="description" 
                        label="Description" 
                        placeholder="input product description" 
                        isrequired 
                        disabled={isUpdate ? true : false} />
                    <TextField 
                        name="detail" 
                        label="Detail" 
                        placeholder="input product detail" 
                        isrequired 
                        disabled={isUpdate ? true : false} />
                    <TextField 
                        name="price" 
                        label="Price" 
                        placeholder="input product price" 
                        isrequired 
                        disabled={isUpdate ? true : false} />
                     <SelectField 
                        name="isFeatured" 
                        label="IsFeatured" 
                        options={IsFeaturedProduct}
                        isrequired  />
                    

                    <div className="d-flex">
                        <div className="ml-auto">
                            <button className="btn btn-danger"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>

                            <Link to={PRODUCT} className="btn btn-outline-secondary ml-2">
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
