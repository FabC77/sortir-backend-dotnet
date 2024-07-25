using Domain.models.entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class SortieContext : DbContext
    {
        public DbSet<Sortie> Sortie { get; set; }

        public SortieContext(DbContextOptions<SortieContext> options): base(options)
        {
            
        }
    }
}
