using BuscarEndereco.Core.Interfaces;
using BuscarEndereco.Core.Interfaces.Repositorios;
using BuscarEndereco.Core.Servicos;
using BuscarEndereco.Persistencia.Repositorios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IBuscarEnderecoServico, BuscarEnderecoServico>();
builder.Services.AddSingleton<IBuscarEnderecoRepositorio, BuscarEnderecoRepositorio>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
