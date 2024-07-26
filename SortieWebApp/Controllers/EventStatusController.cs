using Application;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EventWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventStatusController : ControllerBase
    {
      private IEtatService _eventStatusService {  get; set; }

        private readonly ILogger<EventStatusController> _logger;

        public EventStatusController(ILogger<EventStatusController> logger, IEtatService eventStatusService)
        {
            _logger = logger;
            _eventStatusService = eventStatusService;
        }

        [HttpGet(Name = "GetEventStatus")]
        public List<EventStatusDto> Get()
        {
            return _eventStatusService.GetEventStatus();
        }

     
    }
}
