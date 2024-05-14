using Aplicacion.Servicios;
using Dominio.Bases;
using Dominio.Repositorios;
using Infraestructura.Bases;
using Infraestructura.Persistencia;
using Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<PersonaServicio>();

// Configuration of interfaces approaches
builder.Services.AddTransient(typeof(IEntidadBase<>), typeof(EntidadBase<>));
builder.Services.AddTransient<IPersonaRepositorio, PersonaRepositorio>();

builder.Services.AddDbContext<BDArquitecturaDDDContext>(options =>
{
    var connectionString = "Server=localhost; Database=BDArquitecturaDDD; Trusted_Connection=True; Integrated security=true; TrustServerCertificate=true;";
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin");

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.Run();

