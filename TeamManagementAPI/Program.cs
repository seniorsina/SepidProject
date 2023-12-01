using DataContext;
using Microsoft.EntityFrameworkCore;
using TeamManagementAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.ConfigureDbContext();
builder.Services.ConfigureTeamRepository();
builder.Services.ConfigureSysListRepository();
builder.Services.ConfigurePlayerRepository();

var app = builder.Build();

// Configure the HTTP request pipeline.

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<TeamDbContext>(); 


    context.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
