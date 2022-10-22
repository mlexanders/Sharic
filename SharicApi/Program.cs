using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharicApi;
using SharicApi.Controllers;
using SharicApi.Middlewares;
using SharicApi.Repository;
using SharicCommon.Data.Models;

internal class Program
{
    private static void Main(string[] args)
    {
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
        builder.Services.AddAuthentication();

        RegistratePaths(builder.Services);

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

        app.UseCors(x => x
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .SetIsOriginAllowed(origin => true)
                       .AllowCredentials());

        app.UseHttpsRedirection();


        var serviceScopeForPermision = app.Services.CreateScope().ServiceProvider;
        app.UseMiddleware<CheckPermisionMiddleware>(serviceScopeForPermision.GetService<BaseCrudRepository<Driver>>());

        app.MapControllers();

        app.Run();
    }

    private static void RegistratePaths(IServiceCollection sc)
    {
        List<AvailablePath> availablePaths = new()
        {
            new AvailablePath("/api/Auth", HttpMethod.Post)
        };

        sc.AddSingleton(availablePaths);
    }
}