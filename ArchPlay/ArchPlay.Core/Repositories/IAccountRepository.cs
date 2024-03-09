using ArchPlay.Core.Entities;

namespace ArchPlay.Core.Repositories;

public interface IAccountRepository
{
    BankAccount Add(Guid accountHolderId);

    BankAccount GetAccountById(Guid accountId);

    BankAccount GetAccountByIBAN(string iban);

    ICollection<BankAccount> GetBankAccountsForAccountHolder(Guid accountHolderId);


}