using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Application.Interfaces.Repositories;
using Application.Mappers;
using Application.Services;
using Domain.Entities;
using Infrastructure.DataBases;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped(typeof(IBaseRepository<Customer>), typeof(BaseRepository<Customer>));
builder.Services.AddScoped<IBaseService<Customer>, CustomerService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperConfiguration).Assembly);
builder.Services.AddDbContext<EFContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

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
