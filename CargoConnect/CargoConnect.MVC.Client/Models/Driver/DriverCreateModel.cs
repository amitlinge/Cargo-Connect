using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Driver
{
    public class DriverCreateModel
    {

        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [MaxLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [MaxLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6)]
        [MaxLength(20)]
        [RegularExpression(
            @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$",
            ErrorMessage = "Password must contain uppercase, lowercase, number and special character"
        )]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "License number is required")]
        [MinLength(5, ErrorMessage = "License number must be at least 5 characters")]
        [MaxLength(20, ErrorMessage = "License number must be at most 20 characters")]
        public string LicenseNumber { get; set; } = string.Empty;
    }
}
