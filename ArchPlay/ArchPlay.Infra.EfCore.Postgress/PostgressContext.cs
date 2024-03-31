using ArchPlay.Infra.EfCore.Common.EfCoreContext;
using Microsoft.EntityFrameworkCore;

namespace ArchPlay.Infra.EfCore.Postgress;

public class PostgressContext : ArchPlayDbContext
{
    public PostgressContext(DbContextOptions options) : base(options)
    {
    }

}