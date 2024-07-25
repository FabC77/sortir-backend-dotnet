using Application.Dtos;
using Domain.models.entities;
using FluentValidation.Results;

namespace Application
{
    public interface ISortieService
    {
        List<SortieDto> GetSorties();
        bool CreateSortie(SortieDto sortieDto);

        bool DeleteSortie(int sortieId, int userId );
        bool CancelSortie(int sortieId, int userId);
        bool PublishSortie(int sortieId, int userId);
    }
}
