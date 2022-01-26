using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cadenaHotelera.Models;

namespace cadenaHotelera.Data
{
    public class cadenaHoteleraContext : DbContext
    {
        public cadenaHoteleraContext (DbContextOptions<cadenaHoteleraContext> options)
            : base(options)
        {
        }

        public DbSet<cadenaHotelera.Models.Sede> Sede { get; set; }
    }
}
