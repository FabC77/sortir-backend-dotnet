using Domain.models.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class SortieRepository : ISortieRepository
    {
        private SortieContext _sortieContext { get; set; }
        public SortieRepository(SortieContext sortieContext)
        {
            _sortieContext = sortieContext;
        }
        public List<Sortie> GetSorties()
        {
            return _sortieContext.Sortie.AsQueryable().ToList();
        }

        public bool CreateSortie(Sortie sortie)
        {
            try
            {
                _sortieContext.Sortie.Add(sortie);
                _sortieContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la création de la sortie : {ex.Message}");
                return false;
            }
        }

        public bool DeleteSortie(Sortie sortie)
        {
            try
            {
                _sortieContext.Sortie.Remove(sortie);
                _sortieContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la suppression de la sortie : {ex.Message}");
                return false;
            }
        }

        public Sortie GetSortie(int sortie)
        {
            return _sortieContext.Sortie.Find(sortie);
        }

        public bool CancelSortie(Sortie sortie)
        {
            try
            {
                _sortieContext.Sortie.Update(sortie);
                _sortieContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de l'annulation de la sortie : {ex.Message}");
                return false;
            }
        }

        public bool PublishSortie(Sortie sortie)
        {
            try
            {
                _sortieContext.Sortie.Update(sortie);
                _sortieContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la publication de la sortie : {ex.Message}");
                return false;
            }
        }
    }
}
