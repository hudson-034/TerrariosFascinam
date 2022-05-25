using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TerrariosFascinam.Model.Context;
using TerrariosFascinam.Business;
using TerrariosFascinam.Business.Implamentations;
using TerrariosFascinam.Repository;
using TerrariosFascinam.Repository.Implamentations;
using Serilog;
using System;
using System.Collections.Generic;

namespace TerrariosFascinam
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
        }

        //This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {   
            services.AddControllers();

            //Connection Database
            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            //Use when Pomelo.EntityFrameworkCore.MySql is version 3.2.7
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));
            //Use when Pomelo.EntityFrameworkCore.MySql is version 6.0.1
            //services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

            if (Environment.IsDevelopment())
            {
                MigrateDatabase(connection);
            }

            //Versioning API
            services.AddApiVersioning();
            
            //Depency Injection
            services.AddScoped<IClientBusiness, ClientBusinessImplementation>();
            services.AddScoped<IClientRepository, ClientRepositoryImplementation>();
        }

        //This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void MigrateDatabase(string connection)
        {
            try
            {
                var evolveConnection = new MySql.Data.MySqlClient.MySqlConnection(connection);
                var evolve = new Evolve.Evolve(evolveConnection, msg => Log.Information(msg))
                {
                    Locations = new List<String> { "db/migrations", "db/dataset" },
                    IsEraseDisabled = true,
                };
                evolve.Migrate();
            }
            catch (Exception ex)
            {
                Log.Error("Database Migration Failed!", ex);
                throw;
            }
        }
    }
}
