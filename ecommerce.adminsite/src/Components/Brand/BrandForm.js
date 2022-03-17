import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useNavigate } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../shared-components/FormInputs/TextField';
import { LIST_BRAND } from '../../Constants/pages';
import FileUpload from '../../shared-components/FormInputs/FileUpload';
import { createBrandRequest, UpdateBrandRequest } from "./services/request";

const initialFormValues = {
    name: '',
    imageFile: undefined
};

const validationSchema = Yup.object().shape({
    name: Yup.string().required('Required'),
    type: Yup.string().required('Required')
});

const BrandFormContainer = ({ initialBrandForm = {
    ...initialFormValues
} }) => {
    const [loading, setLoading] = useState(false);

    const isUpdate = initialBrandForm.id ? true : false;

    const history = useNavigate();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Brand ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                history.push(LIST_BRAND);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateBrandAsync = async (form) => {
        console.log('update brand async');
        let data = await UpdateBrandRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    const createBrandAsync = async (form) => {  
        console.log('create brand async');
        let data = await createBrandRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    return (
        <Formik
            initialValues={initialBrandForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateBrandAsync({ formValues: values });
                    }
                    else {
                        createBrandAsync({ formValues: values });
                    }

                    setLoading(false);
                }, 1000);
            }}
        >
            {(actions) => (
                <Form className='container intro-y col-lg-6 col-12'>
                    <TextField 
                        name="name" 
                        label="Name" 
                        placeholder="input brand name" 
                        isrequired 
                        disabled={isUpdate ? true : false} />
                    <FileUpload 
                        name="imageFile" 
                        label="Image" 
                        image={actions.values.imagePath} />
                    
                    <div className="row">
                        <button className="btn btn-danger col-lg-5 col-12"
                            type="submit" disabled={loading}
                        >
                            Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                        </button>                            
                        <div className="col-lg-2"><br/></div>
                        <Link to={LIST_BRAND} className="btn btn-outline-secondary col-lg-5 col-12">
                            Cancel
                        </Link>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default BrandFormContainer;
