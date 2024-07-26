using Application;
using Application.Dtos;
using Domain.models.entities;
using Microsoft.AspNetCore.Mvc;

namespace EventWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        private IEventService _evService { get; set; }
        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger, IEventService evService)
        {
            _logger = logger;
            _evService = evService;
        }

        [HttpPost("Create")]
        //[Route("api/ev/create")]
        public IActionResult CreateEvent([FromBody] EventDto evDto)
        {
            try
            {
              if( _evService.CreateEvent(evDto))
                {
                    Console.WriteLine("après create ev controller");

                    return StatusCode(201, "ok");

                }
                return StatusCode(400, "bad request");


            }
            catch (Exception ex)
            {
                Console.WriteLine("dans exception ev controller");

                return StatusCode(500, $"Une erreur s'est produite lors de la création de la ev : {ex.Message}");
            }
        }


        // [HttpDelete("Delete/{id}")]
        [HttpDelete("Delete/{idEvent}")]
        public IActionResult DeleteEvent(int idEvent)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_evService.DeleteEvent(idEvent, userId))
                {
                    return StatusCode(200, "deleted");
                }
                return StatusCode(400, "bad request");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la suppression de la ev : {ex.Message}");

            }
        }

        [HttpPut("Publish/{idEvent}")]
        public IActionResult PublishEvent(int idEvent)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_evService.PublishEvent(idEvent, userId))
                {
                    return StatusCode(200, "published");
                }
                return StatusCode(400, "bad request");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la suppression de la ev : {ex.Message}");

            }
        }

        [HttpPut("Cancel/{idEvent}")]
        public IActionResult CancelEvent(int idEvent)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_evService.CancelEvent(idEvent, userId))
                {
                    return StatusCode(200, "canceled");
                }
                return StatusCode(400, "bad request");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la suppression de la ev : {ex.Message}");

            }
        }
        [HttpGet("Get")]
      //  public List<EventDto> GetEvents()
        public ActionResult<List<EventDto>> GetEvents()
        {
            try
            {
                return _evService.GetEvents();
              
            }
            catch (Exception ex)
            {
                return new List<EventDto>();
            }
        }
    }

}
