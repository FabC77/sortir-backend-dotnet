

using Application.Dtos;
using Domain.models.entities;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services )
        {
            services.AddScoped<IEtatService, EtatService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISortieService, SortieService>();

            services.AddAutoMapper(configurations =>
            {
                configurations.CreateMap<Etat, EtatDto>();
                configurations.CreateMap<Utilisateur, UtilisateurDto>();
                configurations.CreateMap<Sortie, SortieDto>();
                //chemin inverse : 
                configurations.CreateMap<SortieDto, Sortie>();
                configurations.CreateMap<UtilisateurDto, Utilisateur>();
                configurations.CreateMap<EtatDto,Etat>();

            });

            return services;
        }
    }
}
