using CargoConnect.Application.DTOs.Transaction;
using CargoConnect.Application.Interfaces.ExternalServices;
using CargoConnect.Application.Interfaces.Repositories;
using CargoConnect.Application.Interfaces.Services;
using CargoConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Application.Services
{
    public class TransactionService : ITransactionService
    {
        IGenericRepository<TransactionEntity> _transactionRepository;
        IMappingService _mapper;

        public TransactionService(IGenericRepository<TransactionEntity> transactionRepository, IMappingService mapper)
        {
            _transactionRepository= transactionRepository;
            _mapper= mapper;
        }
        public async Task<bool> CreateAsync(TransactionCreateDTO transactionCreateDto)
        {
            bool status = await _transactionRepository.CreateAsync(_mapper.Map<TransactionCreateDTO, TransactionEntity>(transactionCreateDto));
            return status;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            bool status=await _transactionRepository.DeleteAsync(id);
            return status;
        }

        public async Task<List<TransactionViewDTO>> GetAllAsync()
        {
            var transaction = _mapper.MapList<TransactionEntity, TransactionViewDTO>(await _transactionRepository.GetAllAsync());
            return transaction;
        }

        public async Task<TransactionViewDTO> GetByIdAsync(Guid id)
        {
            var transaction = _mapper.Map<TransactionEntity, TransactionViewDTO>(await _transactionRepository.GetByIdAsync(id));
            return transaction;
        }
    }
}
