using System.Collections.Generic;

namespace eCommerce.Shared.Dto.Product
{
    public class ProductCriteriaDto : BaseQueryCriteriaDto
    {
        public string keyword { get; set; }
        public int? CategoryId { get; set; }
    }
}