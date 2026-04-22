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
    public class BookingUpdateDTO
    {
        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(BookingStatus), ErrorMessage = "Invalid status transition")]
        public BookingStatus Status { get; set; } = BookingStatus.Pending;
    }
}
