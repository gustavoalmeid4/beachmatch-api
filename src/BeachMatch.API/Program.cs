using BeachMatch.Application.Interfaces.Services;
using BeachMatch.Application.Services;
using BeachMatch.Domain.Interfaces;
using BeachMatch.Infrastructure.Persistence;
using BeachMatch.Persistence;
using BeachMatch.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BeachMatchDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPlayerService,PlayerService>();

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<BeachMatchDbContext>();
    db.Database.Migrate();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); 
app.UseAuthorization();    

app.MapControllers();

app.Run();