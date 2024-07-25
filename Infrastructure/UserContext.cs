using Domain.models.entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

    

        public UserContext(DbContextOptions<UserContext> options):base(options) {
        
        }
    }
}
