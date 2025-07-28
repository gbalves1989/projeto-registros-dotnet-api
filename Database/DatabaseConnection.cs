using Microsoft.EntityFrameworkCore;
using RegistrosEntradaSaidaAPI.Database.Entities;

namespace RegistrosEntradaSaidaAPI.Database
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options) { }

        public DbSet<Registros> RegistrosEntradaSaida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
