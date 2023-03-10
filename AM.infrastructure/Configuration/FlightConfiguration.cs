using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces.Configuration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("MyFlight");
            builder.HasKey(x => x.FlightId);
            builder.HasMany(x => x.passangers)
               .WithMany(p => p.flights)
               .UsingEntity(u => u.ToTable("flight-passenger"));
            builder.HasOne(f => f.plane)
                .WithMany(p => p.flights)
                .HasForeignKey(f => f.planeID)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
