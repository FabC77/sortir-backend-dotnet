using Domain.models.entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure
{
    public class EventStatusContext : DbContext
    {
        public DbSet<EventStatus> Etat { get; set; }

        public EventStatusContext(DbContextOptions<EventStatusContext> options): base(options) { }
 
    }
}
