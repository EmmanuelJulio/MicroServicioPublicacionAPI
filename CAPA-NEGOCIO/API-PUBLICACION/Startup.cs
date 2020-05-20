using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CAPA_APLICACION.SERVICIOS;
using CAPA_DATOS;
using CAPA_DATOS.COMANDOS;
using CAPA_NEGOCIO.COMANDOS;
using CAPA_NEGOCIO.ENTIDADES;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace API_PUBLICACION
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
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            //EF CORE
            services.AddDbContext<Contexto>(opciones => opciones.UseSqlServer(connectionString));
            //SQL KATA
            
            services.AddTransient<IDbConnection>(b =>
            {
                return new SqlConnection(connectionString);
            });
            services.AddTransient<IGenericRepository, GenericRepository>();
            services.AddTransient<IPublicacionService, PublicacionService>();
            services.AddTransient<IComentarioService, ComentarioService>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
