using System.ComponentModel.DataAnnotations;
using CargoConnect.Common.Enums;

namespace CargoConnect.MVC.Client.Models.Booking
{
    public class BookingUpdateModel
    {
        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(BookingStatus), ErrorMessage = "Invalid status transition")]
        public BookingStatus Status { get; set; } = BookingStatus.Pending;
    }
}
