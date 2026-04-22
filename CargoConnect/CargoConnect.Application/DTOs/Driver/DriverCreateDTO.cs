using System.ComponentModel.DataAnnotations;

public class DriverCreateDTO
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
        @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&]).{6,}$",
        ErrorMessage = "Password must contain uppercase, lowercase, number and special character"
    )]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "License number is required")]
    [MinLength(5)]
    [MaxLength(20)]
    public string LicenseNumber { get; set; } = string.Empty;
}