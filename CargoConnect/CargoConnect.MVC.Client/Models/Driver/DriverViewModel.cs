using CargoConnect.Common.Enums;

namespace CargoConnect.MVC.Client.Models.Driver
{
    public class DriverViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public string LicenseNumber { get; set; }

        public DriverStatus Status { get; set; }

        public float? Rating { get; set; }

        public Roles Role { get; set; }
    }
}
