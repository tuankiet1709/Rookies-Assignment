using System;
using System.ComponentModel.DataAnnotations;

namespace eCommerce.Shared.ViewModel.Customer
{
    public class CustomerVm
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email{get;set;}
        public string PhoneNumber { get; set; }
    }
}