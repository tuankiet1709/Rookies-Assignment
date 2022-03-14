using System;
using Microsoft.AspNetCore.Http.Features;
using System.ComponentModel.DataAnnotations;
using eCommerce.Shared.Enum;
namespace eCommerce.Shared.ViewModel.Category
{
    public class CategoryCreateRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description {get;set;}
        public bool IsShowOnHome { get; set; }
        public int? ParentId { get; set; }


    }
}