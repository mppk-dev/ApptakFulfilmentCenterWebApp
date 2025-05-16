using System.ComponentModel.DataAnnotations;

namespace ApptakFulfilmentCenterWebApp.Models.Dto
{
    public class SignUpDto
    {
        public decimal UserCode { get; set; }


        [Required(ErrorMessage = "First name required")]
        public string? UserFirstName { get; set; }


        [Required(ErrorMessage = "Last name required")]
        public string? UserLastName { get; set; }


        [Required(ErrorMessage = "Email required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? UserEmail { get; set; }

        [Required(ErrorMessage = "Phone no required")]
        [RegularExpression(@"^03[0-9]{9}$", ErrorMessage = "Invalid phone number format.")]
        public string? UserPhoneNo { get; set; }


        [Required(ErrorMessage = "Password required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%#*?&])[A-Za-z\d@$!%#*?&]{8,}$",
        ErrorMessage = "Password must contain at least one uppercase, one lowercase, one number, and one special character")]
        public string UserPassword { get; set; } = null!;


        [Required(ErrorMessage = "Confirm password required")]
        [Compare("UserPassword", ErrorMessage = "Passwords do not match")]
        public string UserConfirmPassword { get; set; } = null!;

        
    }
}
