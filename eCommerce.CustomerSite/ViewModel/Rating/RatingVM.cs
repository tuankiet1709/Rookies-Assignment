using System.ComponentModel.DataAnnotations;

namespace eCommerce.CustomerSite.ViewModel.Rating
{
    public class RatingVm
    {
        public int ProductId {get;set;}
        [Required]
        public string ReviewerName {get;set;}
        public int RatePoint {get;set;}
        public string Comment {get;set;}
        public DateTime RateDate {get;set;}
        public bool IsApproved {get;set;}
        public bool IsDelete {get;set;}
    }
}
