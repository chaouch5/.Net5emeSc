using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.infrastructure.Configuration
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passanger>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Passanger> builder)
        {

            builder.OwnsOne(f => f.fullName, x =>
        {
            x.Property(f => f.firstName).HasColumnName("FirstName").HasMaxLength(20).HasColumnType("varchar");
            x.Property(f => f.lastName).HasColumnName("LastName").HasMaxLength(20).HasColumnType("varchar");
        });
        }
        }
}
