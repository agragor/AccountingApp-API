using AccountingApp_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountingApp_API.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        // In-memory list to store transactions
        private readonly List<Transaction> _transactions = new List<Transaction>();

        // Gets all transactions
        public List<Transaction> GetTransactions()
        {
            return _transactions;
        }

        // Gets a specific transaction by its ID
        public Transaction GetTransactionById(Guid transactionId)
        {
            return _transactions.FirstOrDefault(t => t.TransactionId == transactionId);
        }

        // Adds a new transaction
        public void CreateTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }
    }
}
