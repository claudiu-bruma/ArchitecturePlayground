using ArchPlay.Core.Enums;

namespace ArchPlay.Core.Interfaces;

public interface ITransactionService
{
    Guid CreateTransaction(
        Guid userId,
        Guid accountId,
        TransactionTypes transactionType,
        decimal amount,
        string transactionName);
}