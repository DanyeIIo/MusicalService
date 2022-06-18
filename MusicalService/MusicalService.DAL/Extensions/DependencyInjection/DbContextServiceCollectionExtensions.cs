using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicalService.Application.Ports.DataAccess.PostgreSql;

namespace MusicalService.Infrastructure.Adapters.DAL.PostgreSQL.Extensions.DependencyInjection;

public static class DbContextServiceCollectionExtensions
{
    public static IServiceCollection AddMusicalServiceDbContext(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<IMusicalServiceDbContext, MusicalServiceDbContext>((services, options) =>
        {
            var configuration = services.GetRequiredService<IConfiguration>();
            options.UseNpgsql(configuration.GetConnectionString("MusicalServiceDatabase"));
        });

        return serviceCollection;
    }
}