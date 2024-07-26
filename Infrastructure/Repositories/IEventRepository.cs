using Domain.models.entities;

namespace Infrastructure.Repositories
{
    public interface IEventRepository
    {
        List<Event> GetEvents();

        public bool CreateEvent(Event ev);
        Event GetEvent(int ev);

        public bool DeleteEvent(Event ev);
        public bool CancelEvent(Event ev);
        public bool PublishEvent(Event ev);
    }
}
