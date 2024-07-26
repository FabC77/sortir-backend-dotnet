using Application.Dtos;
using Domain.models.entities;
using FluentValidation.Results;

namespace Application
{
    public interface IEventService
    {
        List<EventDto> GetEvents();
        bool CreateEvent(EventDto eventDto);

        bool DeleteEvent(int eventId, int userId );
        bool CancelEvent(int eventId, int userId);
        bool PublishEvent(int eventId, int userId);
    }
}
