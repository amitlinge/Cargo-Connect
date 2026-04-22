using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Vehical
{
    public class VehicalUpdateDTO
    {
        [Range(0.1, 100, ErrorMessage = "Length must be greater than 0")]
        public double? Length { get; set; }

        [Range(0.1, 100, ErrorMessage = "Width must be greater than 0")]
        public double? Width { get; set; }

        [Range(0.1, 100, ErrorMessage = "Height must be greater than 0")]
        public double? Height { get; set; }

        [Range(1, 100000, ErrorMessage = "Load capacity must be greater than 0")]
        public double? LoadCapacity { get; set; }
    }
}
