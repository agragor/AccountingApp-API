using AccountingApp_API.Models;
using System;
using System.Collections.Generic;

namespace AccountingApp_API.Repositories
{
    public interface ITransactionRepository
    {
        List<Transaction> GetTransactions();
        Transaction GetTransactionById(Guid transactionId);
        void CreateTransaction(Transaction transaction);
    }
}
