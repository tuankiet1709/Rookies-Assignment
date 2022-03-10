const Endpoints = {
    authorize: 'api/authorize',
    me: 'api/authorize/me',

    brand: '/api/brands',
    brandId: (id) => `api/brands/${id}`,

    product: 'api/products',
    productId: (id)=>`api/products/${id}`

};

export default Endpoints;