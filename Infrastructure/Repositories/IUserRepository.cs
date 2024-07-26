using Domain.models.entities;


namespace Infrastructure.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
