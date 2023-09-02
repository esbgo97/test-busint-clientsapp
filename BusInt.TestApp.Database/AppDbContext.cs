using BusInt.TestApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusInt.TestApp.Database
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL("Server=localhost;Database=AppTest;User=root;Password=root1234;");
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Ciudad> Ciudades{ get; set; }
    }
}
