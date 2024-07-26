using Application.Dtos;
using AutoMapper;
using Domain.models.entities;
using Infrastructure.Repositories;
namespace Application
{
    public class UserService : IUserService
    {
        public readonly IMapper _mapper;
        private IUserRepository _userRepository {  get; set; }
        public UserService(IUserRepository userRepository, IMapper mapper) { 
        
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public List<UserDto> GetUsers()
        {
            var users = _userRepository.GetUsers();
            return _mapper.Map<List<UserDto>>(users);   

        }
    }
}
