using Microsoft.EntityFrameworkCore;
using squadAPI2.Database;
using squadAPI2.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionMySql = builder.Configuration
.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ConfigDbContext>(
    options => options.UseMySql(connectionMySql,
    ServerVersion.Parse("8.0.29-mysql"))
);


builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ICadastroEscolaRepository, CadastroEscolaRepository>();
builder.Services.AddScoped<ICadastroEmpresaRepository, CadastroEmpresaRepository>();
builder.Services.AddScoped<IDemandaEscolaRepository, DemandaEscolaRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
