using DL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(option =>
{
    option.AddPolicy("Policy", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});
builder.Services.AddControllers(); // Si usas API controllers
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PodcastContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("PodcastContext")));

builder.Services.AddScoped<BL.IPodcast, BL.Podcast>();
builder.Services.AddScoped<BL.ICategoria, BL.Categoria>();
builder.Services.AddScoped<BL.IEpisodio, BL.Episodio>();
builder.Services.AddScoped<BL.IIdioma, BL.Idioma>();


var app = builder.Build();


app.UseDefaultFiles();
app.UseStaticFiles();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Policy"); // Habilita CORS
app.UseRouting();
app.MapControllers(); // Mapea endpoints de API

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
