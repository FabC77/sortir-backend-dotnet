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

        private IEventService _sortieService { get; set; }
        private readonly ILogger<EventController> _logger;

        public EventController(ILogger<EventController> logger, IEventService sortieService)
        {
            _logger = logger;
            _sortieService = sortieService;
        }

        [HttpPost("Create")]
        //[Route("api/sortie/create")]
        public IActionResult CreateEvent([FromBody] EventDto sortieDto)
        {
            try
            {
              if( _sortieService.CreateEvent(sortieDto))
                {
                    Console.WriteLine("après create sortie controller");

                    return StatusCode(201, "ok");

                }
                return StatusCode(400, "bad request");


            }
            catch (Exception ex)
            {
                Console.WriteLine("dans exception sortie controller");

                return StatusCode(500, $"Une erreur s'est produite lors de la création de la sortie : {ex.Message}");
            }
        }


        // [HttpDelete("Delete/{id}")]
        [HttpDelete("Delete/{idEvent}")]
        public IActionResult DeleteEvent(int idEvent)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_sortieService.DeleteEvent(idEvent, userId))
                {
                    return StatusCode(200, "deleted");
                }
                return StatusCode(400, "bad request");

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la suppression de la sortie : {ex.Message}");

            }
        }

        [HttpPut("Publish/{idEvent}")]
        public IActionResult PublishEvent(int idEvent)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_sortieService.PublishEvent(idEvent, userId))
                {
                    return StatusCode(200, "published");
                }
                return StatusCode(400, "bad request");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la suppression de la sortie : {ex.Message}");

            }
        }

        [HttpPut("Cancel/{idEvent}")]
        public IActionResult CancelEvent(int idEvent)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_sortieService.CancelEvent(idEvent, userId))
                {
                    return StatusCode(200, "canceled");
                }
                return StatusCode(400, "bad request");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Une erreur s'est produite lors de la suppression de la sortie : {ex.Message}");

            }
        }
        [HttpGet("Get")]
      //  public List<EventDto> GetEvents()
        public ActionResult<List<EventDto>> GetEvents()
        {
            try
            {
                return _sortieService.GetEvents();
              
            }
            catch (Exception ex)
            {
                return new List<EventDto>();
            }
        }
    }

}
