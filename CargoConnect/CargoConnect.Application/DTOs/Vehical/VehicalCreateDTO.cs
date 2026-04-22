using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Vehical
{
    public class VehicalCreateDTO
    {

        [Required(ErrorMessage = "DriverId is required")]
        public Guid DriverId { get; set; }

        [Required(ErrorMessage = "Vehicle type is required")]
        [EnumDataType(typeof(VehicalType), ErrorMessage = "Invalid vehicle type")]
        public VehicalType Type { get; set; }

        [Required(ErrorMessage = "Number plate is required")]
        [MinLength(5, ErrorMessage = "Number plate must be at least 5 characters")]
        [MaxLength(15, ErrorMessage = "Number plate cannot exceed 15 characters")]
        public string NumberPlate { get; set; } = string.Empty;

        [Required]
        [Range(0.1, 100, ErrorMessage = "Length must be greater than 0")]
        public double Length { get; set; }

        [Required]
        [Range(0.1, 100, ErrorMessage = "Width must be greater than 0")]
        public double Width { get; set; }

        [Required]
        [Range(0.1, 100, ErrorMessage = "Height must be greater than 0")]
        public double Height { get; set; }

        [Required]
        [Range(1, 100000, ErrorMessage = "Load capacity must be greater than 0")]
        public double LoadCapacity { get; set; }
    }
}
