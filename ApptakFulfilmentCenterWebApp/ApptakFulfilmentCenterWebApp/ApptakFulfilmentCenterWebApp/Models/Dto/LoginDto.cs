using System.ComponentModel.DataAnnotations;

namespace ApptakFulfilmentCenterWebApp.Models.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; } = null!;
    }
}
