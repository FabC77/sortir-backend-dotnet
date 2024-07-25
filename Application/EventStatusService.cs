using Application.Dtos;
using AutoMapper;
using Domain.models.entities;
using Infrastructure;
namespace Application
{
    public class EventStatusService : IEtatService
    {
        public readonly IMapper _mapper;
        private IEventStatusRepository _etatRepository { get; set; }

        public EventStatusService(IEventStatusRepository etatRepository, IMapper mapper)
        {
           _etatRepository = etatRepository;
            _mapper = mapper;
        }

        public List<EventStatusDto> GetEtats()
        {

            var etats = _etatRepository.GetEtats();
           return _mapper.Map<List<EventStatusDto>>(etats);
        }
    }
}
