using Domain.models.entities;
using Infrastructure.Contexts;


namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private SortirContext _userContext { get; set; }
        public UserRepository(SortirContext userContexte)
        {
            _userContext = userContexte;
        }

        public List<User> GetUsers()
        {
            return _userContext.Users.AsQueryable().ToList();
        }

    }
}
