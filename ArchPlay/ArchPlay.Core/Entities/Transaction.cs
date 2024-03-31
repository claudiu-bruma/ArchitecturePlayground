using ArchPlay.Core.Enums;

namespace ArchPlay.Core.Entities;

public class Transaction
{ 
    public Guid TransactionId { get; set; }
    public Guid AccountId { get; set; }
    public string TransactionName { get; set; }
    public decimal Ammount { get; set; }
    public TransactionTypes TransactionType { get; set; }
}