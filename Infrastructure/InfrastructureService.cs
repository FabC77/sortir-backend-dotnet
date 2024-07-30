using Domain.models.entities;
using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureService
    {
        private static readonly IConfiguration _configuration;

        static InfrastructureService()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();
        }
        public static IServiceCollection AddInfrastructure(this IServiceCollection services )
        {
           
            services.AddScoped<IEventStatusRepository, EventStatusRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IEventRepository, EventRepository>();

            string connectionString = _configuration.GetConnectionString("SortirNVME");


            services.AddDbContext<SortirContext>(options => options.UseSqlServer(connectionString));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<SortirContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
//services.AddDbContext<EventContext>(options => options.UseSqlServer("Data Source=LAPTOP-Fab\\MSSQLSERVER04;Initial Catalog=evDb;Integrated Security=True;Trust Server Certificate=True"));
//services.AddDbContext<EventStatusContext>(options => options.UseSqlServer("Data Source=LAPTOP-Fab\\MSSQLSERVER04;Initial Catalog=evDb;Integrated Security=True;Trust Server Certificate=True"));
