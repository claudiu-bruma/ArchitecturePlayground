using ArchPlay.Infra.EfCore.Common.EfCoreContext;
using ArchPlay.Infra.EfCore.Postgress;
using Microsoft.EntityFrameworkCore;

namespace ArchPlay.Api.Setup;
public static class DbContextWireup
{
    public static void AddPostgressSQL(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<PostgressContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));
    }


    public static void AddSQLServer(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ArchPlayDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));
    }
}