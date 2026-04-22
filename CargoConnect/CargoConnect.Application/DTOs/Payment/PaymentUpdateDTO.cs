using CargoConnect.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Payment
{
    public class PaymentUpdateDTO
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
