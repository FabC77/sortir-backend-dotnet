using Application.Dtos;
using AutoMapper;
using Domain.models.entities;
using Infrastructure.Repositories;
namespace Application
{
    public class EventStatusService : IEtatService
    {
        public readonly IMapper _mapper;
        private IEventStatusRepository _eventStatusRepository { get; set; }

        public EventStatusService(IEventStatusRepository eventStatusRepository, IMapper mapper)
        {
           _eventStatusRepository = eventStatusRepository;
            _mapper = mapper;
        }

        public List<EventStatusDto> GetEventStatus()
        {

            var eventStatus = _eventStatusRepository.GetEventStatus();
           return _mapper.Map<List<EventStatusDto>>(eventStatus);
        }
    }
}
