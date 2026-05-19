using ProyectoUno.Aplicacion.Servicios;
using ProyectoUno.Dominio.Interfaces;
using ProyectoUno.Persistencia.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioCuenta, RepositorioCuentaEnMemoria>();
builder.Services.AddScoped<CrearCuentaService>();
builder.Services.AddScoped<ObtenerCuentaPorIdService>();
builder.Services.AddScoped<EliminarCuentaService>();
builder.Services.AddScoped<RetiraDineroCuentaService>();
// Registrar servicios MVC / Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(); // Esto habilita la interfaz visual
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();