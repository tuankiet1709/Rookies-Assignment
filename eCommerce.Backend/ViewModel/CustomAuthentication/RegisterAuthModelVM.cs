using System.ComponentModel.DataAnnotations;

namespace eCommerce.Backend.ViewModel.CustomAuthentication
{
    public class RegisterAuthModelVM
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        public string ReturnUrl { get; set; }
    }
}