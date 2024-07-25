using Application.Dtos;

namespace Application
{
    public interface IEtatService
    {
        List<EtatDto> GetEtats();
    }
}
