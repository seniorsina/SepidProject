using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Modle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Configuration;
public class FlConfiguration : IEntityTypeConfiguration<Fl>
{
    public void Configure(EntityTypeBuilder<Fl> builder)
    {
        builder.HasData(
            new Fl { Id = 1, Name = "color" },
            new Fl { Id = 2, Name = "teamType" },
            new Fl { Id = 3, Name = "grade" }
            );
    }
}
