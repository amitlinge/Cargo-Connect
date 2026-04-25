using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Application.DTOs.Payment;

namespace CargoConnect.Application.Interfaces.Services
{
    public interface IPaymentService
    {
        Task<List<PaymentViewDTO>> GetAllAsync();
        Task<PaymentViewDTO> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(PaymentCreateDTO paymentCreateDTO);
        Task<bool> UpdateAsync(PaymentUpdateDTO paymentUpdateDTO);
        Task<bool> DeleteAsync(Guid id);
    }
}
