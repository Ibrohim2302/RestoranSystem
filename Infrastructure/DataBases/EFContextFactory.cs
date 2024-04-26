using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.DataBases;

public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
{
    public EFContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<EFContext>();
        return new EFContext(optionBuilder.Options);
    }
}
