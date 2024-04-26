using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.TablesConfiguration;

public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Name).HasMaxLength(100).IsRequired();
        builder.Property(m => m.Description).HasMaxLength(256).IsRequired();
        builder.Property(m => m.Price).HasPrecision(18, 2).IsRequired();
        builder.Property(m => m.Category).HasConversion<string>().IsRequired();
    }
}
