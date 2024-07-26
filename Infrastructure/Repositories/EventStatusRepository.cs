using Domain.models.entities;
using Infrastructure.Contexts;
namespace Infrastructure.Repositories
{
    public class EventStatusRepository : IEventStatusRepository
    {
        private SortirContext _context { get; set; }
        public EventStatusRepository(SortirContext eventStatusContexte)
        {
            _context = eventStatusContexte;
        }

        public List<EventStatus> GetEventStatus()
        {
            return _context.EventStatus.AsQueryable().ToList();
        }

    }
}
