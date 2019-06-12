using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Exercise_App.API.Application.Behaviours;
using Exercise_App.API.Application.Exceptions;
using Exercise_App.API.Persistence;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;

[assembly: ApiController]
namespace Exercise_App.API.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.GetAssembly(typeof(ExerciseAppException))));

            services.AddLogger();

            services.AddDbContext<ExerciseAppContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddRepositories();

            services.AddMediatR(Assembly.GetAssembly(typeof(ExerciseAppException)));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ExerciseAppContext>();
                context.Database.EnsureCreated();
            }


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseExceptionHandler(ExceptionHandler);
            app.UseHttpsRedirection();
            app.UseMvc();
        }

        private void ExceptionHandler(IApplicationBuilder app)
        {
            app.Run(ctx =>
            {
                return Task.Run(async () =>
                {
                    ctx.Response.StatusCode = 500;
                    var exHandlerPathFeature = ctx.Features.Get<IExceptionHandlerPathFeature>();

                    var exception = exHandlerPathFeature.Error;
                    var uri = ctx.Request.Path;

                    var logger = app.ApplicationServices.GetService<ILogger>();
                    logger.Error(exception, "Error occured when processing request {uri}", uri);

                    await ctx.Response.WriteAsync($"Error Ocurred: {exception.Message}. {(exception.InnerException?.Message)}");
                });
            });
        }
    }
}
