using ArchPlay.Core.Enums;
using ArchPlay.Core.Interfaces;
using ArchPlay.Core.Repositories;

namespace ArchPlay.Core.Services;

public class TransactionService : ITransactionService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IUserRepository _userRepository;
    private readonly ITransactionRepository _transactionRepository;
    public TransactionService(
        IUserRepository userRepository, 
        IAccountRepository accountRepository,
        ITransactionRepository transactionRepository)
    {
        _userRepository = userRepository;
        _accountRepository = accountRepository;
        _transactionRepository = transactionRepository;
    }

    public Guid CreateTransaction(
        Guid userId,
        Guid accountId,
        TransactionTypes transactionType,
        decimal amount,
        string transactionName)
    {
        if (amount == 0)
        {
            throw new ArgumentOutOfRangeException($"Amount for transaction cannot be 0");
        }
        var user = _userRepository.GetUserById(userId);
        if (user is null)
        {
            throw new ArgumentException($"User id does not exist : {userId}");
        }

        var account = _accountRepository.GetAccountById(accountId);
        if (account is null)
        {
            throw new ArgumentException($"Account id does not exist : {accountId}");
        }

        if (account.AccountHolderId != userId)
        {
            throw new InvalidOperationException($"User {userId} is not authorized on the account {accountId}");
        }

        var transactionGuid = _transactionRepository.Add(
            user.UserId,
            account.AccountId,
            transactionType,
            amount, transactionName);

        return transactionGuid;
    }
}