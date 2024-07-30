using Domain.models.entities;
using Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Infrastructure.Contexts
{
    public class SortirContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        private readonly IConfiguration _configuration;
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventStatus> EventStatus { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<City> Cities { get; set; }



        public SortirContext(DbContextOptions<SortirContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("SortirNVME");
                optionsBuilder
                    .UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(a => a.EventsCreated)
                .WithOne()
                .HasForeignKey(a => a.OrganizerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Campus>()
                .HasMany(a => a.Students)
                .WithOne()
                .HasForeignKey(a => a.CampusId);

            modelBuilder.Entity<Campus>()
          .HasMany(a => a.Events)
          .WithOne(a=>a.Campus)
          .HasForeignKey(a => a.CampusId);

            modelBuilder.Entity<City>()
                .HasMany(a => a.Locations)
                .WithOne()
                .HasForeignKey(a => a.CityId);

            modelBuilder.Entity<Location>()
                .HasMany(a => a.Events)
                .WithOne(a=>a.Location)
                .HasForeignKey(u => u.LocationId);
       
      
            

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Members)
                .WithMany(u => u.Events)
                   .UsingEntity<Dictionary<string, object>>(
            "EventsMembers", 
            j => j.HasOne<User>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.NoAction),
            j => j.HasOne<Event>().WithMany().HasForeignKey("EventId").OnDelete(DeleteBehavior.NoAction)
        );

            base.OnModelCreating(modelBuilder);
        }
    }
}
