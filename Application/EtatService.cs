using Application.Dtos;
using AutoMapper;
using Domain.models.entities;
using Infrastructure;
namespace Application
{
    public class EtatService : IEtatService
    {
        public readonly IMapper _mapper;
        private IEtatRepository _etatRepository { get; set; }

        public EtatService(IEtatRepository etatRepository, IMapper mapper)
        {
           _etatRepository = etatRepository;
            _mapper = mapper;
        }

        public List<EtatDto> GetEtats()
        {

            var etats = _etatRepository.GetEtats();
           return _mapper.Map<List<EtatDto>>(etats);
        }
    }
}
