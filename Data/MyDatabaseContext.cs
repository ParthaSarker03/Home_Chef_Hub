using HomeChefHub.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace HomeChefHub.Data
{
    public class MyDatabaseContext : DbContext 
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options) : base(options) {

        }
        public DbSet<Admin>Admins { get; set; }
        
    }
}
