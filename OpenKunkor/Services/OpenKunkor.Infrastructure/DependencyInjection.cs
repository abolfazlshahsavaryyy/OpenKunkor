// Infrastructure/DependencyInjection.cs
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenKunkor.Infrastructure.Data;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // EF Core setup
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Register any repository or service
        

        return services;
    }
}
