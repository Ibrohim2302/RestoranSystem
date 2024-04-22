using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.TablesConfiguration;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasKey(rc => rc.Id);
        builder.Property(rc => rc.Date).IsRequired();
        builder.Property(rc => rc.NumberOfGuests).IsRequired();
        builder.HasOne(rc => rc.Customer).WithMany(rc => rc.Reservations).HasForeignKey(rc => rc.CustomerId);
    }
}
