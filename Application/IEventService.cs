using Application.Dtos;
using Domain.models.entities;
using FluentValidation.Results;

namespace Application
{
    public interface IEventService
    {
        List<EventDto> GetSorties();
        bool CreateSortie(EventDto sortieDto);

        bool DeleteSortie(int sortieId, int userId );
        bool CancelSortie(int sortieId, int userId);
        bool PublishSortie(int sortieId, int userId);
    }
}
