using Domain.models.entities;
using Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private EventContext _sortieContext { get; set; }
        public EventRepository(EventContext sortieContext)
        {
            _sortieContext = sortieContext;
        }
        public List<Event> GetSorties()
        {
            return _sortieContext.Sortie.AsQueryable().ToList();
        }

        public bool CreateSortie(Event sortie)
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

        public bool DeleteSortie(Event sortie)
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

        public Event GetSortie(int sortie)
        {
            return _sortieContext.Sortie.Find(sortie);
        }

        public bool CancelSortie(Event sortie)
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

        public bool PublishSortie(Event sortie)
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
