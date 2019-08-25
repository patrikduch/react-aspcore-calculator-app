//-----------------------------------------------------------------------
// <copyright file="Startup.cs" website="Patrikduch.com">
//     Copyright 2019 (c) Patrikduch.com
// </copyright>
// <author>Patrik Duch</author>
//-----------------------------------------------------------------------

using System.IO;
using Calculator.Web.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Calculator.Web
{
    /// <summary>
    /// Init configuration setup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Injectable reference to the configuration setup.
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <seealso cref="Startup"/> class.
        /// </summary>
        /// <param name="env">Hosting environment that will be injected.</param>
        public Startup(IHostingEnvironment env)
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true);

            if (env.IsDevelopment())

                builder.AddUserSecrets<Startup>();


            Configuration = builder.Build();

        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services">Collection of services that can be added to the container.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Db context service
            services.AddDbContext<CalculatorLogContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // MVC service registration
            services.AddMvc();
        }

        /// <summary>
        /// Configuration invocation
        /// </summary>
        /// <param name="app">Request pipeline object confguration</param>
        /// <param name="env">Hosting environment that will be injected.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Serving static files from wwwroot directory
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {

                #region Server routing
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                #endregion

                #region Spa Fallback
                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });

                #endregion

            });
        }
    }
}
