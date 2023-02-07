using Microsoft.EntityFrameworkCore;
using Yien_Express.Model;

namespace Yien_Express.Data

{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        { 
        }
        public DbSet<Package> packages { get; set; }
        public DbSet<Customer> customers { get; set; }

        public DbSet<Employee> employees { get; set; }

        public DbSet<Order> orders { get; set; }
        
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>().
                Property(p => p.Price).HasColumnType("decimal(18,2)");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "Data Source=DESKTOP-H6ES71O;Initial Catalog=YienDB;TrustServerCertificate=True;Persist Security Info=True;Integrated Security=True";
            optionsBuilder.UseSqlServer(connection);

        }
    }
}
