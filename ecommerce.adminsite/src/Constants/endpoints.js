const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',

    brand: '/api/brands',
    brandId: (id) => `api/brands/${id}`,

    product: 'api/products',
    productId: (id)=>`api/products/${id}`,

    category: 'api/categories',
    categoryOption: 'api/categories/option',
    categoryId: (id)=>`api/categories/${id}`,

};

export default Endpoints;