using Application.Dtos;


namespace Application
{
    public interface IUserService
    {
        List<UserDto> GetUsers();
    }
}
