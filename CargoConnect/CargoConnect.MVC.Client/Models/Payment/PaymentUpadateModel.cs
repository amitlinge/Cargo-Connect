using CargoConnect.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Payment
{
    public class PaymentUpadateModel
    {

        [Required(ErrorMessage = "Id is required")]
        public Guid Id { get; set; }

        [Range(1, 1000000, ErrorMessage = "Amount must be greater than 0")]
        public decimal? Amount { get; set; }

        [EnumDataType(typeof(PaymentStatus), ErrorMessage = "Invalid status")]
        public PaymentStatus? Status { get; set; }

        [EnumDataType(typeof(PaymentMethod), ErrorMessage = "Invalid payment method")]
        public PaymentMethod? PaymentMethod { get; set; }

        public Guid? TransactionId { get; set; }
    }
}
