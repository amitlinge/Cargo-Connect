using CargoConnect.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.DTOs.Payment
{
    public class GetPaymentDTO
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus Status { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public Guid TransactionId { get; set; }
    }
}
