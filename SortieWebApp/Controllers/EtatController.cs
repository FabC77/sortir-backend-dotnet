using Application;
using Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace SortieWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EtatController : ControllerBase
    {
      private IEtatService _etatService {  get; set; }

        private readonly ILogger<EtatController> _logger;

        public EtatController(ILogger<EtatController> logger, IEtatService etatService)
        {
            _logger = logger;
            _etatService = etatService;
        }

        [HttpGet(Name = "GetEtats")]
        public List<EtatDto> Get()
        {
            return _etatService.GetEtats();
        }

     
    }
}
