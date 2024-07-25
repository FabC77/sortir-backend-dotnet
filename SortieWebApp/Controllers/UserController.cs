using Application;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService { get; set; }
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet(Name = "GetUsers")]
        public List<UserDto> GetUsers()
        {
            return _userService.GetUsers();
        }
    }
}
