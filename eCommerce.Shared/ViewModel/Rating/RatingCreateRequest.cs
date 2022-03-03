using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using eCommerce.Shared.Enum;
using System;

namespace eCommerce.Shared.ViewModel.Rating
{
    public class RatingCreateRequest
    {
        [Required]
        public int ProductId {get;set;}
        [Required]
        public int RatePoint {get;set;}
        [Required]
        public string ReviewerName {get;set;}
        public string Comment {get;set;}
        public DateTime RateDate {get;set;}
        public bool IsApproved {get;set;}
        public bool IsDelete {get;set;}
    }
}
