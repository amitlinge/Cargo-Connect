using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.Application.DTOs.Transaction
{
    public class TransactionCreateDTO
    {
        [Required(ErrorMessage = "BookingId is required")]
        public Guid BookingId { get; set; }

        [Required(ErrorMessage = "UserId is required")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "DriverId is required")]
        public Guid DriverId { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(1, 1000000, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(TransactionStatus), ErrorMessage = "Invalid status")]
        public TransactionStatus Status { get; set; }

        [Required(ErrorMessage = "Transaction type is required")]
        [EnumDataType(typeof(TransactionType), ErrorMessage = "Invalid transaction type")]
        public TransactionType Type { get; set; }

        [Required(ErrorMessage = "Payment gateway is required")]
        [MinLength(3)]
        [MaxLength(50)]
        public string PaymentGateway { get; set; } = string.Empty;

        [Required(ErrorMessage = "Gateway transaction Id is required")]
        [MinLength(5)]
        [MaxLength(100)]
        public string GatewayTransactionId { get; set; } = string.Empty;
    }
}
