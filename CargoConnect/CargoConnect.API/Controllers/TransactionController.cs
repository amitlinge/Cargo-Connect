using CargoConnect.Application.DTOs.Transaction;
using CargoConnect.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CargoConnect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        //GET: api/transactions
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var transactions = await _transactionService.GetAllAsync();
            return Ok(transactions);
        }

        //GET: api/transactions/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(Guid id)
        {
            var transaction = await _transactionService.GetByIdAsync(id);
            if (transaction == null)
                return NotFound("Transaction not found");
            return Ok(transaction);
        }

        //POST: api/transactions
        [HttpPost()]
        public async Task<IActionResult> Create([FromBody]TransactionCreateDTO transactionCreateDto)
        {
            if (ModelState.IsValid)
            {
                bool status = await _transactionService.CreateAsync(transactionCreateDto);
                if (status)
                {
                    return Created("", transactionCreateDto);
                }
                return BadRequest();
            }
            return BadRequest();
        }

        //DELETE: api/Transactions
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            bool status = await _transactionService.DeleteAsync(id);
            if (status)
            {
                return Ok("Transaction deleted successfully");
            }
            return NotFound("Transaction not found");
        }
    }
}
