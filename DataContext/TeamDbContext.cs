using DataContext.Configuration;
using Microsoft.EntityFrameworkCore;
using Models.Model;
using Models.Modle;
using System.Reflection.Emit;

namespace DataContext;
public class TeamDbContext:DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Fl> Fls { get; set; }
    public DbSet<SysList> SysLits { get; set; }
    
    public TeamDbContext(DbContextOptions<TeamDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TeamConfiguration());
        modelBuilder.ApplyConfiguration(new FlConfiguration());
        modelBuilder.ApplyConfiguration(new SysListConfiguration());
    }



}
