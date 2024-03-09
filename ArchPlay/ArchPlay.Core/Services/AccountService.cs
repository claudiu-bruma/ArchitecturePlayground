using ArchPlay.Core.Entities;
using ArchPlay.Core.Interfaces;
using ArchPlay.Core.Repositories;

namespace ArchPlay.Core.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IUserRepository _userRepository;

    public AccountService(IAccountRepository accountRepository,
        IUserRepository userRepository)
    {
        _userRepository = userRepository;
        _accountRepository = accountRepository;
    }

    public ICollection<BankAccount> GetAccountsForUser(Guid accountHolder)
    {
        var user = _userRepository.GetUserById(accountHolder);
        if (user is null)
        {
            return null;
        }

        var accounts = _accountRepository.GetBankAccountsForAccountHolder(user.UserId);
        return accounts;
    }

    public BankAccount CreateAccount(Guid accountHolder)
    {
        var user = _userRepository.GetUserById(accountHolder);
        if (user is null)
        {
            return null;
        }

        var account = _accountRepository.Add(accountHolder);

        return account;
    }
}