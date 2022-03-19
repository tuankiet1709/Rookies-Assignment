using AutoMapper;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using eCommerce.Shared.Dto;
using eCommerce.Shared.Dto.Product;
using eCommerce.Backend.Data;
using eCommerce.Backend.Extension;
using Microsoft.AspNetCore.Authorization;
using eCommerce.Shared.ViewModel.Product;
using eCommerce.Backend.Models;
using eCommerce.Shared.Enum;

namespace eCommerce.Backend.Services
{
    public class ProductService:IProductService{
        private readonly ApplicationDbContext _context;
        private readonly IFileStorageService _fileStorageService;
        private readonly IMapper _mapper;
        public ProductService(
                ApplicationDbContext context,
                IFileStorageService fileStorageService,
                IMapper mapper)
        {
            _context = context;
            _fileStorageService=fileStorageService;
            _mapper = mapper;
        }
        //get product and paging
        public async Task<PagedResponseDto<ProductDto>> GetProductAsync(ProductCriteriaDto productCriteriaDto)
        {
            //query
            var query =_context.Products.AsQueryable();
            //Filter (search product by name)
            if (!string.IsNullOrEmpty(productCriteriaDto.Search))
            {
                query = query.Where(x => x.Name.Contains(productCriteriaDto.Search));
            }
            //Fileter (get product by category id)
            if (productCriteriaDto.CategoryId != null && productCriteriaDto.CategoryId != 0)
            {
                query=query.Where(x => x.CategoryId==productCriteriaDto.CategoryId);
            }
            //paging 
            var pagedProducts = await query
                                .AsNoTracking()
                                .PaginateAsync(productCriteriaDto);
            //mapping IEnumerable<Product> to IEnumerable<ProductDto>
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
        //Get top 10 product is featured
        public async Task<List<ProductDto>> GetFeaturedProducts()
        {
            //query
            var query= await _context.Products.Where(x=>x.IsFeatured==true).Take(10).ToListAsync();
            //mapping List<Product> to List<ProductDto>
            var productDto = _mapper.Map<List<ProductDto>>(query);
            return productDto;
        }
        //Get top 10 lastest product
        public async Task<List<ProductDto>> GetLastestProduct()
        {
            //query
            var query= await _context.Products.OrderByDescending(x=>x.CreatedDate).Take(10).ToListAsync();
            //mapping List<Product> to List<ProductDto>
            var productDto = _mapper.Map<List<ProductDto>>(query);
            return productDto;
        }
        //Create new product
        public async Task<ProductDto> PostProduct(ProductCreateRequest productCreateRequest)
        {
            //Create new product
            var product = new Product
            {
                Name=productCreateRequest.Name,
                Description=productCreateRequest.Description,
                Details=productCreateRequest.Details,
                Images=string.Empty,
                OriginalPrice=productCreateRequest.OriginalPrice,
                Price=productCreateRequest.Price,
                IsFeatured=productCreateRequest.IsFeatured,
                BrandId=productCreateRequest.BrandId,
                CategoryId=productCreateRequest.CategoryId,
            };
            //Add product image
            if (productCreateRequest.ImageFile != null)
            {
                product.Images = await _fileStorageService.SaveFileAsync(productCreateRequest.ImageFile);
            }
            //add product to db
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
            
        }
        //Update 1 product
        public async Task<int> PutProduct(int id, ProductUpdateRequest productUpdateRequest)
        {
            //find product by id
            var product = await _context.Products.FindAsync(id);
            //edit product info
            product.Name=productUpdateRequest.Name;
            product.Description=productUpdateRequest.Description;
            product.Details=productUpdateRequest.Details;
            product.UpdatedDate=DateTime.Now;
            product.OriginalPrice=productUpdateRequest.OriginalPrice;
            product.Price=productUpdateRequest.Price;
            product.IsFeatured=productUpdateRequest.IsFeatured;
            product.BrandId=productUpdateRequest.BrandId;
            product.CategoryId=productUpdateRequest.CategoryId;
            //update product image
            if (productUpdateRequest.ImageFile != null)
            {
                product.Images = await _fileStorageService.SaveFileAsync(productUpdateRequest.ImageFile);
            }
            //update product to db
            _context.Products.Update(product);
            return await _context.SaveChangesAsync();
        }
        //delete 1 product (soft delete)
        public async Task<int> DeleteProduct(int id)
        {
            //find product by id
            var product = await _context.Products.FindAsync(id);
            //update product status to db
            product.isDeleted = true;
            _context.Products.Update(product);
            return await _context.SaveChangesAsync();
        }
        //get 1 product by id
        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            //get product by Id
            var product = await _context.Products.Where(x=>x.Id == id).FirstOrDefaultAsync();
            //mapping Product to ProductDto
            var productDto = _mapper.Map<ProductDto>(product);

            return productDto;
        }
    }
}
    

    