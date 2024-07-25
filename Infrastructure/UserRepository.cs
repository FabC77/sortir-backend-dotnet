using Domain.models.entities;


namespace Infrastructure
{
    public class UserRepository: IUserRepository
    {
        private UserContext _userContext { get; set; }
        public UserRepository(UserContext userContexte)
        {
            _userContext = userContexte;
        }

        public List<User> GetUsers()
        {
            return _userContext.Users.AsQueryable().ToList();
        }

    }
}
