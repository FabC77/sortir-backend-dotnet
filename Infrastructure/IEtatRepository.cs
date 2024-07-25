using Domain.models.entities;
namespace Infrastructure
{
    public interface IEtatRepository
    {

        List<Etat> GetEtats();
    }
}
