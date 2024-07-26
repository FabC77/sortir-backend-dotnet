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
        private SortirContext _context { get; set; }
        public EventRepository(SortirContext sortieContext)
        {
            _context = sortieContext;
        }
        public List<Event> GetEvents()
        {
            return _context.Events.AsQueryable().ToList();
        }

        public bool CreateEvent(Event sortie)
        {
            try
            {
               // _context.Event.Add(sortie);
                _context.Events.Add(sortie);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la création de la sortie : {ex.Message}");
                return false;
            }
        }

        public bool DeleteEvent(Event sortie)
        {
            try
            {
                _context.Events.Remove(sortie);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la suppression de la sortie : {ex.Message}");
                return false;
            }
        }

        public Event GetEvent(int sortie)
        {
            return _context.Events.Find(sortie);
        }

        public bool CancelEvent(Event sortie)
        {
            try
            {
                _context.Events.Update(sortie);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de l'annulation de la sortie : {ex.Message}");
                return false;
            }
        }

        public bool PublishEvent(Event sortie)
        {
            try
            {
                _context.Events.Update(sortie);
                _context.SaveChanges();
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
