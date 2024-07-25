using Application.Dtos;
using Application.validators;
using AutoMapper;
using Domain.models.entities;
using FluentValidation;
using FluentValidation.Results;
using Infrastructure;

namespace Application
{
    public class SortieService : ISortieService
    {
        private readonly IMapper _mapper;
        private ISortieRepository _sortieRepository { get; set; }
        public SortieService(ISortieRepository sortieRepository, IMapper mapper)
        {
            _sortieRepository = sortieRepository;
            _mapper = mapper;
        }
        public List<SortieDto> GetSorties()
        {
            var sorties = _sortieRepository.GetSorties();
            return _mapper.Map<List<SortieDto>>(sorties);
        }

        public bool CreateSortie(SortieDto sortieDto)
        {
            Sortie sortie = _mapper.Map<Sortie>(sortieDto);
            sortie.IdEtat = 2;
            SortieValidator validator = new SortieValidator();

            validator.ValidateAndThrow(sortie);

            return _sortieRepository.CreateSortie(sortie); 
        }

            public bool DeleteSortie(int sortieId, int userId )
        {
            //////

            Sortie sortie = _sortieRepository.GetSortie(sortieId);

            if (sortie != null && sortie.IdOrganisateur.Equals(userId))
            {

                return _sortieRepository.DeleteSortie(sortie);

            }
            else return false;

        }

        public bool CancelSortie(int sortieId, int userId)
        {
            Sortie sortie = _sortieRepository.GetSortie(sortieId);


            if (sortie != null && sortie.IdOrganisateur.Equals(userId))
            {
                sortie.IdEtat = 4;

                return _sortieRepository.CancelSortie(sortie);

            }
            else return false;

        }

        public bool PublishSortie(int sortieId, int userId)
        {
            Sortie sortie = _sortieRepository.GetSortie(sortieId);


            if (sortie != null && sortie.IdOrganisateur.Equals(userId))
            {
                sortie.IdEtat = 1;

                return _sortieRepository.PublishSortie(sortie);

            }
            else return false;
        }
    }
}
