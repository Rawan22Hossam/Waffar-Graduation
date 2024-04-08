
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Waffar.Context;
using Waffar.EntityConfigurations.MapperConfigurations;
using Waffar.Models;

namespace Waffar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
        
            builder.Services.AddControllers();
            builder.Services.AddDbContext<ApplicationContext>(options =>
          options.UseSqlServer(builder.Configuration.GetConnectionString("Waffar")));
           
          
            // Auto Mapper Config
            var mappConfig = new MapperConfiguration(t => 
            {
                t.AddProfile(typeof(MapperConfig));
            });
            var mapper = mappConfig.CreateMapper();
            builder.Services.AddSingleton(mapper);

            //Authorization Roles
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("RequireAdministratorRole",
                     policy => policy.RequireRole("Admin"));          //For Admin
                options.AddPolicy("RequireUserRole",
                     policy => policy.RequireRole("User"));         //For User 
                options.AddPolicy("ForAuthorizedUsers",
                     policy => policy.RequireRole("Admin", "User"));  // For Both

            });

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
        }
    }
}