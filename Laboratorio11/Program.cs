using Laboratorio11.Models;
using Laboratorio11.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BibliotecaContext>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAutoresRepositorio, AutoresRepositorioEF>();
builder.Services.AddScoped<ILivroRepositorio, LivroRepositorioEF>();
builder.Services.AddScoped<IEmprestimoRepositorio, EmprestimoRepositorioEF>();

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
