const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',

    brand: '/api/brands',
    brandOption: 'api/brands/option',
    brandId: (id) => `api/brands/${id}`,

    product: 'api/products',
    productId: (id)=>`api/products/${id}`,

    category: 'api/categories',
    categoryOption: (getParam)=>`api/categories/option?getParam=${getParam}`,
    categoryId: (id)=>`api/categories/${id}`,

};

export default Endpoints;