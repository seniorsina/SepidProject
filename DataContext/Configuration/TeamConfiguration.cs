using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Configuration;
public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasData(
            new Team { Id = 1, Name = "تیم 1", EstablishmentِDate = "1390/01/01", TeamType = "فوتبال", Grade = "لیگ برتر", FirstColor = "قرمز", SecondColor = "سفید" },
            new Team { Id = 2, Name = "تیم 2", EstablishmentِDate = "1391/02/02", TeamType = "بسکتبال", Grade = "دسته اول", FirstColor = "آبی", SecondColor = "سفید" },
            new Team { Id = 3, Name = "تیم 3", EstablishmentِDate = "1392/03/03", TeamType = "والیبال", Grade = "دسته دوم", FirstColor = "سفید", SecondColor = "زرد" },
            new Team { Id = 4, Name = "تیم 4", EstablishmentِDate = "1393/04/04", TeamType = "فوتبال", Grade = "لیگ برتر", FirstColor = "قرمز", SecondColor = "آبی" },
            new Team { Id = 5, Name = "تیم 5", EstablishmentِDate = "1394/05/05", TeamType = "بسکتبال", Grade = "دسته اول", FirstColor = "زرد", SecondColor = "مشکی" },
            new Team { Id = 6, Name = "تیم 6", EstablishmentِDate = "1395/06/06", TeamType = "والیبال", Grade = "دسته دوم", FirstColor = "مشکی", SecondColor = "قرمز" },
            new Team { Id = 7, Name = "تیم 7", EstablishmentِDate = "1396/07/07", TeamType = "هندبال", Grade = "لیگ برتر", FirstColor = "آبی", SecondColor = "سفید" },
            new Team { Id = 8, Name = "تیم 8", EstablishmentِDate = "1397/08/08", TeamType = "بسکتبال", Grade = "دسته اول", FirstColor = "سفید", SecondColor = "زرد" },
            new Team { Id = 9, Name = "تیم 9", EstablishmentِDate = "1398/09/09", TeamType = "والیبال", Grade = "دسته دوم", FirstColor = "زرد", SecondColor = "آبی" },
            new Team { Id = 10, Name = "تیم 10", EstablishmentِDate = "1399/10/10", TeamType = "فوتبال", Grade = "لیگ برتر", FirstColor = "مشکی", SecondColor = "قرمز" }
        );

    }
}
