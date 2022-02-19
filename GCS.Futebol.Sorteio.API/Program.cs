using GCS.Futebol.Sorteio.BD.Contextos;
using GCS.Futebol.Sorteio.BD.Repositorios;
using GCS.Futebol.Sorteio.Entidades.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var services = builder.Services;

var stringDeConexaoPadrao = builder.Configuration.GetConnectionString("Padrao");
services.AddDbContext<ContextoAtleta>(options => options.UseSqlServer(stringDeConexaoPadrao));

services.AddScoped<ContextoAtleta>();
services.AddScoped<IRepositorioAtleta, RepositorioAtleta>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
