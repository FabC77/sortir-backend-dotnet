using Domain.models.entities;

namespace Infrastructure.Repositories
{
    public interface IEventRepository
    {
        List<Event> GetEvents();

        public bool CreateEvent(Event sortie);
        Event GetEvent(int sortie);

        public bool DeleteEvent(Event sortie);
        public bool CancelEvent(Event sortie);
        public bool PublishEvent(Event sortie);
    }
}
