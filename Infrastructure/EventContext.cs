using Domain.models.entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class EventContext : DbContext
    {
        public DbSet<Event> Sortie { get; set; }

        public EventContext(DbContextOptions<EventContext> options): base(options)
        {
            
        }
    }
}
