


using Revisao.Data.Providers.MongoDb;
using Microsoft.Extensions.Options;
using H1Store.Catalogo.Data.AutoMapper;
using Revisao.Application.AutoMapper;
using Revisao.Data.Providers.MongoDb.Configuration;
using Revisao.Data.Providers.MongoDb.Interfaces;
using Revisao.Data.Repositories;
using Revisao.Application.Interfaces;
using Revisao.Application.Services;
using Newtonsoft.Json.Linq;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Interfaces;
using Revisao.Infra.Autenticacao.Models;
using Revisao.Infra.Autenticacao;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
       serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));
builder.Services.AddAutoMapper(typeof(DomainToCollection), typeof(CollectionToDomain));

builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));

builder.Services.AddScoped<IPapaiNoelRepository, PapaiNoelRepository>();
builder.Services.AddScoped<IPapaiNoelService, PapaiNoelService>();

builder.Services.Configure<Token>(
    builder.Configuration.GetSection("token"));

builder.Services.AddScoped<ITokenService, TokenService>();


var app = builder.Build();

// Configure the HTTP request pipeli
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();