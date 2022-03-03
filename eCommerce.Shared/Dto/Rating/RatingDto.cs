using System;

namespace eCommerce.Shared.Dto.Rating
{
    public class RatingDto
    {
        public int RateId {get;set;}
        public int ProductId {get;set;}
        public string ReviewerName {get;set;}
        public int RatePoint {get;set;}
        public string Comment {get;set;}
        public DateTime RateDate {get;set;}
        public bool IsApproved {get;set;}
        public bool IsDelete {get;set;}
    }
}