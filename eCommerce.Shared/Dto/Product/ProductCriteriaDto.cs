using System.Collections.Generic;

namespace eCommerce.Shared.Dto.Product
{
    public class ProductCriteriaDto : BaseQueryCriteriaDto
    {
        public int? CategoryId { get; set; }
        public int? Type{get;set;}
    }
}