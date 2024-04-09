using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rm_sciage.application.Contracts.Persistance;
using rm_sciage.persistance.Repository;

namespace rm_sciage.persistance;

public static class PersistanceDependencyInjection
{
    public static IServiceCollection AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RmsciageDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("RmsciageDb"));
        });

        services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}