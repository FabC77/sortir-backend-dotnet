using Application.Dtos;


namespace Application
{
    public interface IUserService
    {
        List<UtilisateurDto> GetUsers();
    }
}
