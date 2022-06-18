using MusicalService.Application.Ports.DataAccess.PostgreSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.Extensions;

public static class HostExtensions
{
    public static IHost MigrateDatabase<TDbContext>(this IHost host) where TDbContext : IMusicalServiceDbContext
    {
        using var serviceScope = host.Services.CreateScope();

        using var dbContext = serviceScope.ServiceProvider.GetRequiredService<TDbContext>();

        dbContext.Database.Migrate();

        return host;
    }
}