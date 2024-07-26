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
        public EventRepository(SortirContext evContext)
        {
            _context = evContext;
        }
        public List<Event> GetEvents()
        {
            return _context.Events.AsQueryable().ToList();
        }

        public bool CreateEvent(Event ev)
        {
            try
            {
               // _context.Event.Add(ev);
                _context.Events.Add(ev);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la création de la ev : {ex.Message}");
                return false;
            }
        }

        public bool DeleteEvent(Event ev)
        {
            try
            {
                _context.Events.Remove(ev);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la suppression de la ev : {ex.Message}");
                return false;
            }
        }

        public Event GetEvent(int ev)
        {
            return _context.Events.Find(ev);
        }

        public bool CancelEvent(Event ev)
        {
            try
            {
                _context.Events.Update(ev);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de l'annulation de la ev : {ex.Message}");
                return false;
            }
        }

        public bool PublishEvent(Event ev)
        {
            try
            {
                _context.Events.Update(ev);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite lors de la publication de la ev : {ex.Message}");
                return false;
            }
        }
    }
}
