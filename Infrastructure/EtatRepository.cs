using Domain.models.entities;
namespace Infrastructure
{
    public class EtatRepository : IEtatRepository
    {
        private EtatContext _etatContexte { get; set; }
        public EtatRepository(EtatContext etatContexte)
        {
            _etatContexte = etatContexte;
        }

        public List<Etat> GetEtats()
        {
            return _etatContexte.Etat.AsQueryable().ToList();
        }

    }
}
