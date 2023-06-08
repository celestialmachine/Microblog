using System.ComponentModel.DataAnnotations;

namespace Microblog.Models
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your password.")]
        public string OldPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a new password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string NewPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm the new password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
