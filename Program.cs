using Microsoft.EntityFrameworkCore;
using sistema_blibiotecario_api.Data;
using sistema_blibiotecario_api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var ConnectionString = builder.Configuration.GetConnectionString("AppConnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(ConnectionString,ServerVersion.AutoDetect(ConnectionString)));
builder.Services.AddTransient<ILivroRepository, LivroRepository>();
builder.Services.AddTransient<IAutorRepository, AutorRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();

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
