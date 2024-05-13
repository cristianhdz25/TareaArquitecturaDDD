var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configuration of interfaces approaches
//builder.Services.AddTransient<IRoomTypeRepository, RoomTypeRepository>();
//builder.Services.AddTransient<IRoomRepository, RoomRepository>()

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
