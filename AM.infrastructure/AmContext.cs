using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Interfaces.Configuration;
using AM.infrastructure.Configuration;

namespace AM.infrastructure
{
    public  class AmContext: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration() );
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.Entity<Flight>().ToTable("MyFlight");
            modelBuilder.Entity<Flight>().HasKey(f=>f.FlightId);
           // modelBuilder.Entity<Passanger>().Property(f=>f.FirstName).HasColumnType("PassengerName")
            //    .IsRequired()
              //  .HasColumnType("varchar");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(50);
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<Double>().HavePrecision(2,3);
        }


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
