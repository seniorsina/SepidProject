using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataContext.Configuration;
internal class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder
        .HasOne(p => p.Team)
        .WithMany(t => t.Players)
        .HasForeignKey(p => p.TeamId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}
