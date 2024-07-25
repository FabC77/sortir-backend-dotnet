using Domain.models.entities;


namespace Infrastructure
{
    public interface IUserRepository
    {
        List<Utilisateur> GetUsers();
    }
}
