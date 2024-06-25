using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FutureEducationalPlatform.Persistence
{
    public static class ServiceExtension
    {
        public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();


        }
    }
}
