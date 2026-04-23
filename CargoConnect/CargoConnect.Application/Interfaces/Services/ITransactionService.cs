using CargoConnect.Application.DTOs.Transaction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CargoConnect.Application.Interfaces.Services
{
    public interface ITransactionService
    {
        Task<List<TransactionViewDTO>> GetAllAsync();

        Task<TransactionViewDTO> GetByIdAsync(Guid id);

        Task<bool> CreateAsync(TransactionCreateDTO transactionCreateDto);

        Task<bool> DeleteAsync(Guid id);
    }
}