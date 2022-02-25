using System.Collections.Generic;
using eCommerce.Shared.Dto;

namespace eCommerce.Shared.ViewModel.Product
{
    public class GetProductPagingRequest : BaseQueryCriteriaDto
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}