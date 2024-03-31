using ArchPlay.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArchPlay.Infra.EfCore.Common.EfCoreContext;

public class ArchPlayDbContext : DbContext
{    
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<User> Users { get; set; }

    public ArchPlayDbContext(DbContextOptions options) : base(options)
    {
    }
    
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseNpgsql();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Model configuration here if needed
    }
}