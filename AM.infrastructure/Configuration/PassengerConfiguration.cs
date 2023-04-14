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
    public class passengerConfiguration : IEntityTypeConfiguration<Passanger>
    {
        public void Configure(EntityTypeBuilder<Passanger> builder)
        {
            builder.OwnsOne(f => f.fullName, x =>
            {
                x.Property(f => f.firstName).HasColumnName("FirstName").HasMaxLength(20).HasColumnType("varchar");
                x.Property(f => f.lastName).HasColumnName("LastName").HasMaxLength(20).HasColumnType("varchar");
            });
        }
    }
}
