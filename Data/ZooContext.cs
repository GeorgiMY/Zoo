using Microsoft.EntityFrameworkCore;
using Zoo.Core;
using Zoo.Data.Entities;

namespace Data
{
    public class ZooContext : DbContext
    {
        public ZooContext() : base() { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Enclosure> Enclosures { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Data Source=STUDENT23;Initial Catalog=Zoo;Integrated Security=True;TrustServerCertificate=True"));
        }
    }
}
