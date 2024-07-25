using Application;
using Application.Dtos;
using Domain.models.entities;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SortieController : ControllerBase
    {

        private ISortieService _sortieService { get; set; }
        private readonly ILogger<SortieController> _logger;

        public SortieController(ILogger<SortieController> logger, ISortieService sortieService)
        {
            _logger = logger;
            _sortieService = sortieService;
        }

        [HttpPost("Create")]
        //[Route("api/sortie/create")]
        public IActionResult CreateSortie([FromBody] SortieDto sortieDto)
        {
            try
            {
              if( _sortieService.CreateSortie(sortieDto))
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
        [HttpDelete("Delete/{idSortie}")]
        public IActionResult DeleteSortie(int idSortie)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_sortieService.DeleteSortie(idSortie, userId))
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

        [HttpPut("Publish/{idSortie}")]
        public IActionResult PublishSortie(int idSortie)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_sortieService.PublishSortie(idSortie, userId))
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

        [HttpPut("Cancel/{idSortie}")]
        public IActionResult CancelSortie(int idSortie)
        {
            try
            {
                int userId = 1; // temporaire. En réalité il faudrait récupérer le token d'authentification, etc.
                if (_sortieService.CancelSortie(idSortie, userId))
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
      //  public List<SortieDto> GetSorties()
        public ActionResult<List<SortieDto>> GetSorties()
        {
            try
            {
                return _sortieService.GetSorties();
              
            }
            catch (Exception ex)
            {
                return new List<SortieDto>();
            }
        }
    }

}
