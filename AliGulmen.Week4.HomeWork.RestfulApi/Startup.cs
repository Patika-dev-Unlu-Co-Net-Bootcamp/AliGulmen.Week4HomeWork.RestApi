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

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AliGulmen.Week4.HomeWork.RestfulApi", Version = "v1" });
            });

            services.AddSingleton<ILoggerService, TextFileLogger>(); // Log the actions to text file, might be changed to ConsoleLogger if necessary
            services.AddSingleton<IStorageService, WarehouseStorage>(); //containers will be located on rack, not directly to shipping.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
