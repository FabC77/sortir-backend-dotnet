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
        private IEventRepository _sortieRepository { get; set; }
        public EventService(IEventRepository sortieRepository, IMapper mapper)
        {
            _sortieRepository = sortieRepository;
            _mapper = mapper;
        }
        public List<EventDto> GetEvents()
        {
            var sorties = _sortieRepository.GetEvents();
            return _mapper.Map<List<EventDto>>(sorties);
        }

        public bool CreateEvent(EventDto sortieDto)
        {
            Event sortie = _mapper.Map<Event>(sortieDto);
            sortie.StatusId = 2;
            EventValidator validator = new EventValidator();

            validator.ValidateAndThrow(sortie);

            return _sortieRepository.CreateEvent(sortie); 
        }

            public bool DeleteEvent(int sortieId, int userId )
        {
            //////

            Event sortie = _sortieRepository.GetEvent(sortieId);

            if (sortie != null && sortie.OrganizerId.Equals(userId))
            {

                return _sortieRepository.DeleteEvent(sortie);

            }
            else return false;

        }

        public bool CancelEvent(int sortieId, int userId)
        {
            Event sortie = _sortieRepository.GetEvent(sortieId);


            if (sortie != null && sortie.OrganizerId.Equals(userId))
            {
                sortie.StatusId = 4;

                return _sortieRepository.CancelEvent(sortie);

            }
            else return false;

        }

        public bool PublishEvent(int sortieId, int userId)
        {
            Event sortie = _sortieRepository.GetEvent(sortieId);


            if (sortie != null && sortie.OrganizerId.Equals(userId))
            {
                sortie.StatusId = 1;

                return _sortieRepository.PublishEvent(sortie);

            }
            else return false;
        }
    }
}
