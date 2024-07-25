using Domain.models.entities;
namespace Infrastructure
{
    public interface IEventStatusRepository
    {

        List<EventStatus> GetEtats();
    }
}
