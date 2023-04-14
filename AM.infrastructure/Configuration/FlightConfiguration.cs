using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class flightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("MyFlight");
            builder.HasKey(f => f.FlightId);

            builder.HasMany(f => f.passangers)
                .WithMany(P => P.flights)
                .UsingEntity(u => u.ToTable("flight_passenger"));

            builder.HasOne(f => f.plane)
                .WithMany(p => p.flights)
                .HasForeignKey(f => f.planeId)
                .OnDelete(DeleteBehavior.SetNull);
                


        }

    }
}
