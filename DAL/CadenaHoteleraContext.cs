using cadenaHotelera.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace cadenaHotelera.DAL
{
    public class CadenaHoteleraContext : DbContext
    {
        public CadenaHoteleraContext() : base("CadenaHoteleraContext")
        {
        }

        public DbSet<Sede> Sede { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        public DbSet<Alojamiento> Alojamiento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
