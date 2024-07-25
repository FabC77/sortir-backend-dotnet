using Domain.models.entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure
{
    public class EtatContext : DbContext
    {
        public DbSet<Etat> Etat { get; set; }

        public EtatContext(DbContextOptions<EtatContext> options): base(options) { }
 
    }
}
