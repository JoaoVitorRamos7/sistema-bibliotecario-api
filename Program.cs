using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using sistema_bibliotecario_api.Data;
using sistema_bibliotecario_api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var ConnectionString = builder.Configuration.GetConnectionString("AppConnectionString");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString)));
builder.Services.AddTransient<ILivroRepository, LivroRepository>();
builder.Services.AddTransient<IAutorRepository, AutorRepository>();
builder.Services.AddTransient<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("HabilitarFront-endLocal",
        policy =>
        {
            policy
                .WithOrigins("http://localhost:2000")
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});



var app = builder.Build();
app.UseCors("HabilitarFront-endLocal");

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
