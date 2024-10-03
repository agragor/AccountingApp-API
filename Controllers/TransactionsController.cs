using AccountingApp_API.Models;
using AccountingApp_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AccountingApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionsController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        [HttpGet]
        public ActionResult<List<Transaction>> GetTransactions()
        {
            return Ok(_transactionRepository.GetTransactions());
        }

        [HttpGet("{transactionId}")]
        public ActionResult<Transaction> GetTransaction(Guid transactionId)
        {
            var transaction = _transactionRepository.GetTransactionById(transactionId);
            if (transaction == null) return NotFound();
            return Ok(transaction);
        }

        [HttpPost]
        public ActionResult CreateTransaction(Transaction transaction)
        {
            _transactionRepository.CreateTransaction(transaction);
            return CreatedAtAction(nameof(GetTransaction), new { transactionId = transaction.TransactionId }, transaction);
        }
    }
}
