using AutoMapper;
using JsonWebToken.API.Core.Application.Interfaces;
using JsonWebToken.API.Core.Application.Mappings;
using JsonWebToken.API.Persistance.Context;
using JsonWebToken.API.Persistance.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IServiceCollection services = builder.Services;
//services.AddControllers();


builder.Services.AddDbContext<JwtContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration["ConnectionString"]);
});
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>() 
    {
        new ProductProfile(),
        new CategoryProfile()
    });
});
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

app.UseAuthorization();

app.MapControllers();

app.Run();
