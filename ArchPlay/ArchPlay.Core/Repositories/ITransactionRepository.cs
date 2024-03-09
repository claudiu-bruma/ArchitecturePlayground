using ArchPlay.Core.Entities;
using ArchPlay.Core.Enums;

namespace ArchPlay.Core.Repositories;

public interface ITransactionRepository
{
    Guid Add(Guid userId, Guid accountId, TransactionTypes transactionType, decimal amount, string transactionName);
    ICollection<Transaction> GetTransactionsForUser(Guid userId);
    ICollection<Transaction> GetTransactionsForAccount(Guid accountId);
    Transaction GetTransactionById(Guid transactionId);
}