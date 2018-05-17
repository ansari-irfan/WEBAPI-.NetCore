using HPPanelServices.Data;
using HPPanelServices.Data.Repository.Implementations;
using HPPanelServices.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HPPanelServices.API
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
            services.AddDbContext<HPPanelDBConext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddTransient(IRepository<>, typeof(Repository<>));
            services.AddScoped<UnitOfWork<HPPanelDBConext>, UnitOfWork<HPPanelDBConext>>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseAuthentication();

            // app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
