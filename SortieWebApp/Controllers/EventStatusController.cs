using Application;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventStatusController : ControllerBase
    {
      private IEtatService _etatService {  get; set; }

        private readonly ILogger<EventStatusController> _logger;

        public EventStatusController(ILogger<EventStatusController> logger, IEtatService etatService)
        {
            _logger = logger;
            _etatService = etatService;
        }

        [HttpGet(Name = "GetEtats")]
        public List<EventStatusDto> Get()
        {
            return _etatService.GetEtats();
        }

     
    }
}
