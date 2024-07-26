using Domain.models.entities;
using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Contexts
{
    public class SortirContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventStatus> EventsStatus { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<City> Cities { get; set; }



        public SortirContext(DbContextOptions<SortirContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            base.OnModelCreating(modelBuilder);
        }
    }
}
