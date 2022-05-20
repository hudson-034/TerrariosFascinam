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

namespace TerrariosFascinam
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //Connection Database
            var connection = Configuration["MySQLConnection:MySQLConnectionString"];
            //services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));
            services.AddDbContext<MySQLContext>(options => options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

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
    }
}
