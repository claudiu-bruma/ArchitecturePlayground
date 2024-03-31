namespace ArchPlay.Core.Entities;

public class BankAccount
{
    public Guid BankAccountId { get; set; }
    public Guid AccountHolderId { get; set; }
    public Guid AccountId { get; set; }
    public string IBAN { get; set; }
    public DateTime CreatedDate { get; set; }
    public User AccountHolder { get; set; }
    


}