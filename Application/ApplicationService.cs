

using Application.Dtos;
using Domain.models.entities;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services )
        {
            services.AddScoped<IEtatService, EventStatusService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IEventService, EventService>();

            services.AddAutoMapper(configurations =>
            {
                configurations.CreateMap<EventStatus, EventStatusDto>();
                configurations.CreateMap<User, UserDto>();
                configurations.CreateMap<Event, EventDto>();
                //chemin inverse : 
                configurations.CreateMap<EventDto, Event>();
                configurations.CreateMap<UserDto, User>();
                configurations.CreateMap<EventStatusDto,EventStatus>();

            });

            return services;
        }
    }
}
