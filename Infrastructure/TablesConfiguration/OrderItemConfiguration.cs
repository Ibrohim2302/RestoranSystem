using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.TablesConfiguration;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
       builder.HasKey(oi => oi.Id);
       builder.HasOne(oi => oi.MenuItem)
            .WithMany(oi => oi.Items)
            .HasForeignKey(oi => oi.MenuItemId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(oi => oi.Count).IsRequired();
        builder.Property(oi => oi.Status).HasConversion<string>().IsRequired();
    }
}
