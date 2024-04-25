using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<DbContext, PetStoreDbContext>((sp, options) =>
                {
                    options.UseNpgsql(
                        configuration.GetConnectionString("DefaultConnection"))
                    .UseSnakeCaseNamingConvention();
                }
                );
            return services;
        }
    }
}
