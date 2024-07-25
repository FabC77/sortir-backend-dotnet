using Domain.models.entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class UserContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateur { get; set; }

    

        public UserContext(DbContextOptions<UserContext> options):base(options) {
        
        }
    }
}
