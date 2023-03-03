using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructure
{
    public class AmContext: DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passanger> Passangers { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source= (localdb)\mssqllocaldb; initial catalog=Chaouch; integrated security= true");
        }


    }
}
