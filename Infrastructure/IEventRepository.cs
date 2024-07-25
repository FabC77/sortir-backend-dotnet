using Domain.models.entities;

namespace Infrastructure
{
    public interface IEventRepository
    {
        List<Event> GetSorties();

        public bool CreateSortie(Event sortie);
        Event GetSortie(int sortie);

        public bool DeleteSortie(Event sortie);
        public bool CancelSortie(Event sortie);
        public bool PublishSortie(Event sortie);
    }
}
