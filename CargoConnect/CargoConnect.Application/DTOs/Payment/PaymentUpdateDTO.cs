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

        [Required]
        public Guid Id { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public PaymentStatus Status { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        public Guid TransactionId { get; set; }
    }
}
