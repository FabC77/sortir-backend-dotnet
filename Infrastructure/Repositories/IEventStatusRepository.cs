using Domain.models.entities;
namespace Infrastructure.Repositories
{
    public interface IEventStatusRepository
    {

        List<EventStatus> GetEventStatus();
    }
}
