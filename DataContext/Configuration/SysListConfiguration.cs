using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Modle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Configuration;
public class SysListConfiguration : IEntityTypeConfiguration<SysList>
{
    public void Configure(EntityTypeBuilder<SysList> builder)
    {
        builder.HasOne<Fl>().WithMany().HasForeignKey(s => s.Fl).HasPrincipalKey(fl => fl.Id);
        builder.HasData(
            new SysList { Id = 1, Fl = 1, Val = "قرمز" },
            new SysList { Id = 2, Fl = 1, Val = "سفید" },
            new SysList { Id = 3, Fl = 1, Val = "آبی" },
            new SysList { Id = 4, Fl = 1, Val = "مشکی" },
            new SysList { Id = 5, Fl = 1, Val = "زرد" },
            new SysList { Id = 6, Fl = 2, Val = "فوتبال" },
            new SysList { Id = 7, Fl = 2, Val = "بسکتبال" },
            new SysList { Id = 8, Fl = 2, Val = "والیبال" },
            new SysList { Id = 9, Fl = 2, Val = "هندبال" },
            new SysList { Id = 10, Fl = 3, Val = "لیگ برتر" },
            new SysList { Id = 11, Fl = 3, Val = "دسته یک" },
            new SysList { Id = 12, Fl = 3, Val = "دسته دوم" },
            new SysList { Id = 13, Fl = 3, Val = "دسته سوم" }
            );

    }
}
