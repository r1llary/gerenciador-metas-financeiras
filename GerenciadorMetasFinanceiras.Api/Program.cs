using GerenciadorMetasFinanceiras.Core.Interfaces;
using GerenciadorMetasFinanceiras.Core.Services;
using GerenciadorMetasFinanceiras.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMetaFinanceiraRepository, MetaFinanceiraRepository>();

builder.Services.AddScoped<MetaFinanceiraService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();