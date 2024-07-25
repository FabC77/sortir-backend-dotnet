using Domain.models.entities;
namespace Infrastructure
{
    public class EventStatusRepository : IEventStatusRepository
    {
        private EventStatusContext _etatContexte { get; set; }
        public EventStatusRepository(EventStatusContext etatContexte)
        {
            _etatContexte = etatContexte;
        }

        public List<EventStatus> GetEtats()
        {
            return _etatContexte.Etat.AsQueryable().ToList();
        }

    }
}
