using Domain.models.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services )
        {
            services.AddScoped<IEventStatusRepository, EventStatusRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IEventRepository, EventRepository>();

            services.AddDbContext<EventStatusContext>(options => options.UseSqlServer("Data Source=LAPTOP-Fab\\MSSQLSERVER04;Initial Catalog=sortieDb;Integrated Security=True;Trust Server Certificate=True"));
            services.AddDbContext<UserContext>(options => options.UseSqlServer("Data Source=LAPTOP-Fab\\MSSQLSERVER04;Initial Catalog=sortieDb;Integrated Security=True;Trust Server Certificate=True"));
            services.AddDbContext<EventContext>(options => options.UseSqlServer("Data Source=LAPTOP-Fab\\MSSQLSERVER04;Initial Catalog=sortieDb;Integrated Security=True;Trust Server Certificate=True"));

            return services;
        }
    }
}
