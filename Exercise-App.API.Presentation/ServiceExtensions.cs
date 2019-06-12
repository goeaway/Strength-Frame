using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exercise_App.API.Application.Abstractions;
using Exercise_App.API.Application.Models.Entities;
using Exercise_App.API.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Exercise_App.API.Presentation
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddLogger(this IServiceCollection collection)
        {
            var path = Path.Combine(AppContext.BaseDirectory, "log-{Date}.txt");
            var logger = new LoggerConfiguration()
                .WriteTo.RollingFile(path)
                .CreateLogger();

            collection.AddSingleton<ILogger>(logger);
            return collection;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection collection)
        {
            collection.AddTransient<IExerciseAppRepository<Workout>, EFCoreRepository<Workout>>();


            return collection;
        }
    }
}
