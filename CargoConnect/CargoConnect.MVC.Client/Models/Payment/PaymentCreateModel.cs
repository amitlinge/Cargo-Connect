using CargoConnect.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Payment
{
    public class PaymentCreateModel
    {
        [Required(ErrorMessage = "BookingId is required")]
        public Guid BookingId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(1, 1000000, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(PaymentStatus), ErrorMessage = "Invalid payment status")]
        public PaymentStatus Status { get; set; }

        [Required(ErrorMessage = "Payment method is required")]
        [EnumDataType(typeof(PaymentMethod), ErrorMessage = "Invalid payment method")]
        public PaymentMethod PaymentMethod { get; set; }

        [Required(ErrorMessage = "TransactionId is required")]
        public Guid TransactionId { get; set; }
    }
}
