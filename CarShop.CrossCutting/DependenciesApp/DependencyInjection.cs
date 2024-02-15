using CarShop.Domain.Abstractions;
using CarShop.Infrastructure.Context;
using CarShop.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.CrossCutting.DependenciesApp
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlite(connection));
            services.AddScoped<ICarRepository, CarRepository>();

            return services;
        }
    }
}
