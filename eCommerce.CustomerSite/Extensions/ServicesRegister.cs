
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.Shared.Constants;

namespace eCommerce.CustomerSite.Extensions.ServiceCollection
{
    public static class ServiceRegister
    {
        public static void AddServices(this IServiceCollection services)
        {
            // services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<IProductService, ProductService>();

        }
    }
}