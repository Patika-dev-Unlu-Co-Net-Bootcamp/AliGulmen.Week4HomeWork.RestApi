using AliGulmen.Week4.HomeWork.RestfulApi.Filters;
using AliGulmen.Week4.HomeWork.RestfulApi.Middlewares;
using AliGulmen.Week4.HomeWork.RestfulApi.Services.LoggerService;
using AliGulmen.Week4.HomeWork.RestfulApi.Services.StorageService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace AliGulmen.Week4.HomeWork.RestfulApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //we add filters to controller. Because we want it works in each reponse time!
          
            services.AddControllers(config =>
            {
                config.Filters.Add(new CreationTimeFilter());
                config.Filters.Add(new ResponseTimeFilter());
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AliGulmen.Week4.HomeWork.RestfulApi", Version = "v1" });
            });

            services.AddSingleton<ILoggerService, TextFileLogger>(); 
            services.AddSingleton<IStorageService, WarehouseStorage>(); 
        }

   
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AliGulmen.Week4.HomeWork.RestfulApi v1"));
            }


            app.UseCustomGlobalException();

            app.UseCustomLoggingMiddleware();
          
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
