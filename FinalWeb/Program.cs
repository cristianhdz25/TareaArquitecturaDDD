using Dominio.Bases;
using Dominio.Repositorios;
using Infraestructura.Bases;
using Infraestructura.Persistencia;
using Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddRazorPages();

// Configuration of interfaces approaches
builder.Services.AddTransient<IPersonaRepositorio, PersonaRepositorio>();
builder.Services.AddTransient(typeof(IEntidadBase<>), typeof(EntidadBase<>));

builder.Services.AddDbContext<BDArquitecturaDDDContext>(options =>
{
    var connectionString = "Server=localhost; Database=BDArquitecturaDDD; Trusted_Connection=True; Integrated security=true; TrustServerCertificate=true;";
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseCors("AllowOrigin");

app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

app.MapRazorPages();

app.Run();

