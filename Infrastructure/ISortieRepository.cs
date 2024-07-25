using Domain.models.entities;

namespace Infrastructure
{
    public interface ISortieRepository
    {
        List<Sortie> GetSorties();

        public bool CreateSortie(Sortie sortie);
        Sortie GetSortie(int sortie);

        public bool DeleteSortie(Sortie sortie);
        public bool CancelSortie(Sortie sortie);
        public bool PublishSortie(Sortie sortie);
    }
}
