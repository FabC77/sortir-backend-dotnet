using Application.Dtos;
using Application.validators;
using AutoMapper;
using Domain.models.entities;
using FluentValidation;
using FluentValidation.Results;
using Infrastructure.Repositories;

namespace Application
{
    public class EventService : IEventService
    {
        private readonly IMapper _mapper;
        private IEventRepository _eventRepository { get; set; }
        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public List<EventDto> GetEvents()
        {
            var events = _eventRepository.GetEvents();
            return _mapper.Map<List<EventDto>>(events);
        }

        public bool CreateEvent(EventDto eventDto)
        {
            Event ev = _mapper.Map<Event>(eventDto);
            ev.StatusId = 2;
            EventValidator validator = new EventValidator();

            validator.ValidateAndThrow(ev);

            return _eventRepository.CreateEvent(ev); 
        }

            public bool DeleteEvent(int evId, int userId )
        {
            //////

            Event ev = _eventRepository.GetEvent(evId);

            if (ev != null && ev.OrganizerId.Equals(userId))
            {

                return _eventRepository.DeleteEvent(ev);

            }
            else return false;

        }

        public bool CancelEvent(int evId, int userId)
        {
            Event ev = _eventRepository.GetEvent(evId);


            if (ev != null && ev.OrganizerId.Equals(userId))
            {
                ev.StatusId = 4;

                return _eventRepository.CancelEvent(ev);

            }
            else return false;

        }

        public bool PublishEvent(int evId, int userId)
        {
            Event ev = _eventRepository.GetEvent(evId);


            if (ev != null && ev.OrganizerId.Equals(userId))
            {
                ev.StatusId = 1;

                return _eventRepository.PublishEvent(ev);

            }
            else return false;
        }
    }
}
