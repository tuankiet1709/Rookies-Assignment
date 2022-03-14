export const LOGIN='/login';
export const AUTH='/authentication/:action';
export const HOME='/';

export const BRAND = '/brand/*';
export const CREATE_BRAND = '/create';
export const EDIT_BRAND = '/edit/:id';
export const EDIT_BRAND_ID = (id) => `/brand/edit/${id}`;

export const PRODUCT = '/product/*';
export const CREATE_PRODUCT = '/create';
export const EDIT_PRODUCT = '/edit/:id';
export const EDIT_PRODUCT_ID = (id) => `/product/edit/${id}`;

export const CATEGORY = '/category/*';
export const CREATE_CATEGORY = '/create';
export const EDIT_CATEGORY = '/edit/:id';
export const EDIT_CATEGORY_ID = (id) => `/category/edit/${id}`;

export const UNAUTHORIZE = '/unauthorize';
export const NOTFOUND = '/notfound';