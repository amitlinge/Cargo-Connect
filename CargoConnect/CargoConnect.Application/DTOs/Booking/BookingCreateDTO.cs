using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Booking
{
    public class BookingCreateDTO
    {

        [Required(ErrorMessage = "UserId is required")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "DriverId is required")]
        public Guid DriverId { get; set; }

        [Required(ErrorMessage = "Pickup location is required")]
        [MinLength(2, ErrorMessage = "Pickup location must be at least 2 characters")]
        public string PickupLocation { get; set; }

        [MinLength(2, ErrorMessage = "Drop location must be at least 2 characters")]
        public string DropLocation { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Distance must be greater than 0")]
        public double Distance { get; set; }

        [Range(1, 100000, ErrorMessage = "Price must be between 1 and 100000")]
        public decimal Price { get; set; }
    }
}
