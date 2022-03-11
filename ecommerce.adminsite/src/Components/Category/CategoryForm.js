import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useNavigate } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../shared-components/FormInputs/TextField';
import SelectField from '../../shared-components/FormInputs/SelectField';
import { CATEGORY } from '../../Constants/pages';
import { isShowOnHomeOptions } from '../../Constants/selectOptions';
import { createCategoryRequest, UpdateCategoryRequest } from "./services/request";
import { getCategoriesOptionRequest } from "../Category/services/request"

const initialFormValues = {
    name: '',
    description: '',
    isShowOnHome: '',
};

const validationSchema = Yup.object().shape({
    name: Yup.string().required('Required'),
    description: Yup.string().required('Required')
});



const CategoryFormContainer = ({ initialCategoryForm = {
    ...initialFormValues
} }) => {
    const [loading, setLoading] = useState(false);
    const [selectOptions, setSelectOptions] = useState([]);

    useEffect(() => {
        async function fetchDataAsync() {
          let result = await getCategoriesOptionRequest();
          setSelectOptions(result.data)
        }
        
        fetchDataAsync();
      }, []);

    const isUpdate = initialCategoryForm.id ? true : false;

    const navigate = useNavigate();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Category ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                navigate(CATEGORY);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateCategoryAsync = async (form) => {
        console.log('update category async');
        let data = await UpdateCategoryRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    const createCategoryAsync = async (form) => {  
        console.log('create category async');
        let data = await createCategoryRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.name);
        }
    }

    return (
        <Formik
            initialValues={initialCategoryForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateCategoryAsync({ formValues: values });
                    }
                    else {
                        createCategoryAsync({ formValues: values });
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
                        placeholder="input category name" 
                        isrequired  />
                    <TextField 
                        name="description" 
                        label="Description" 
                        placeholder="input category description" 
                        isrequired />
                     <SelectField 
                        name="isShowOnHome" 
                        label="IsShowOnHome" 
                        options={isShowOnHomeOptions}
                        isrequired  />
                    <SelectField 
                        name="parentId" 
                        label="ParentId" 
                        options={
                            selectOptions.map((item) => {
                            return ({id:item.id, label: item.name, value: item.id })
                          })}/>
                    
                    <div className="d-flex">
                        <div className="ml-auto">
                            <button className="btn btn-danger"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>

                            <Link to={CATEGORY} className="btn btn-outline-secondary ml-2">
                                Cancel
                            </Link>
                        </div>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default CategoryFormContainer;
