using ArchPlay.Core.Entities;

namespace ArchPlay.Core.Interfaces;

public interface IAccountService
{
    ICollection<BankAccount> GetAccountsForUser(Guid accountHolder);
    BankAccount CreateAccount(Guid accountHolder);
}