using AutoMapper;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Shared.ViewModel.Product;
using eCommerce.Backend.Data;
using eCommerce.Backend.Models;
using Microsoft.EntityFrameworkCore;
using eCommerce.Backend.Exceptions;
using eCommerce.Backend.Extension;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Backend.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ProductService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Description = request.Description,
                Details = request.Details,
                SeoDescription = request.SeoDescription,
                SeoAlias = request.SeoAlias,
                SeoTitle = request.SeoTitle,
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);

            if (product == null) throw new eCommerceException($"Cannot find a product with id: {request.Id}");

            product.Name = request.Name;
            product.SeoAlias = request.SeoAlias;
            product.SeoDescription = request.SeoDescription;
            product.SeoTitle = request.SeoTitle;
            product.Description = request.Description;
            product.Details = request.Details;

            return await _context.SaveChangesAsync();
        }
        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new eCommerceException($"Cannot find a product: {productId}");

            _context.Products.Remove(product);

            return await _context.SaveChangesAsync();
        }
        public async Task<bool> UpdatePrice(int productId, decimal price)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new eCommerceException($"Cannot find a product with id: {productId}");
            product.Price = price;
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> UpdateStock(int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new eCommerceException($"Cannot find a product with id: {productId}");
            product.Stock += quantity;
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task IncreaseViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount++;
            await _context.SaveChangesAsync();
        }
        public async Task<PagedResponseDto<ProductDto>> GetProducts(
            ProductCriteriaDto productCriteriaDto)
        {
            //query
            var query = from p in _context.Products
                        join pc in _context.ProductCategories on p.Id equals pc.ProductId into ppc
                        from pc in ppc.DefaultIfEmpty()
                        join c in _context.Categories on pc.CategoryId equals c.Id into pcc
                        from c in pcc.DefaultIfEmpty()
                        join pi in _context.ProductImages on p.Id equals pi.ProductId into ppi
                        from pi in ppi.DefaultIfEmpty()
                        // where pi.IsDefault == true
                        select new { p,pc};
            
            //Filter
            if (!string.IsNullOrEmpty(productCriteriaDto.Search))
                query = query.Where(x => x.p.Name.Contains(productCriteriaDto.Search));

            if (productCriteriaDto.CategoryId != null && productCriteriaDto.CategoryId != 0)
            {
                query = query.Where(p => p.pc.CategoryId == productCriteriaDto.CategoryId);
            }

            var pagedProducts = await query
                                .AsNoTracking().Select(x=>x.p)
                                .PaginateAsync(productCriteriaDto);

            var ProductDto = _mapper.Map<IEnumerable<ProductDto>>(pagedProducts.Items);
            return new PagedResponseDto<ProductDto>
            {
                CurrentPage = pagedProducts.CurrentPage,
                TotalPages = pagedProducts.TotalPages,
                TotalItems = pagedProducts.TotalItems,
                Search = productCriteriaDto.Search,
                SortColumn = productCriteriaDto.SortColumn,
                SortOrder = productCriteriaDto.SortOrder,
                Limit = productCriteriaDto.Limit,
                Items = ProductDto
            };
        }
    }
}