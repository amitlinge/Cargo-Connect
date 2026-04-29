using CargoConnect.Common.Enums;

namespace CargoConnect.MVC.Client.Models.Payment
{
    public class PaymentViewModel
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus Status { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public Guid TransactionId { get; set; }
    }
}
