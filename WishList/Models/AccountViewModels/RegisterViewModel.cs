using System.ComponentModel.DataAnnotations;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required,StringLength(100,MinimumLength =8),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), CompareAttribute("Password",ErrorMessage = "The New Password and Confirm New Password fields did not match.")]
        public string ConfirmPassword { get; set; } 

    }
}
