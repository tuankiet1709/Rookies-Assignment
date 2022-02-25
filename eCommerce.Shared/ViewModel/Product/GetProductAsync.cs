using System.Collections.Generic;
using eCommerce.Shared.Dto;

namespace eCommerce.Shared.ViewModel.Product
{
    public class GetProductAsync : BaseQueryCriteriaDto
    {
        public string Keyword { get; set; } = string.Empty;
        public int? CategoryId { get; set; }
    }
}