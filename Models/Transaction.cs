using System;

namespace AccountingApp_API.Models
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }
        public string AccountId { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
