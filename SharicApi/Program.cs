using Microsoft.EntityFrameworkCore;
using SharicApi;
using SharicApi.Controllers;
using SharicApi.Repository;
using SharicCommon.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(connectionString);
});


builder.Services.AddTransient<BaseCrudRepository<Bus>>();
builder.Services.AddTransient<BaseCrudRepository<Driver>>();
builder.Services.AddTransient<BaseCrudRepository<Issue>>();
builder.Services.AddTransient<BaseCrudRepository<Point>>();
builder.Services.AddTransient<BaseCrudRepository<Road>>();
builder.Services.AddTransient<BaseCrudRepository<Trip>>();
builder.Services.AddTransient<BaseCrudRepository<User>>();

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
