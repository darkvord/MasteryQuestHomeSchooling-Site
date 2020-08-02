using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;


namespace MasteryQuestHSSite
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                //endpoints.MapControllerRoute(
                //    name: "Locations",
                //    pattern: "Locations/{action}",
                //    defaults: new { controller = "Locations", action = "LocationSouthBay" });

                //endpoints.MapControllerRoute(
                //    name: "Gear",
                //    pattern: "Gear/{action}",
                //    defaults: new { controller = "Academics", action = "GearOrdering" });

                //endpoints.MapControllerRoute(
                //    name: "Enrollment",
                //    pattern: "Enrollment/{action}",
                //    defaults: new { controller = "Enrollment", action = "CharterSchools" });

                //endpoints.MapControllerRoute(
                //    name: "Academics",
                //    pattern: "Academics/{action}",
                //    defaults: new { controller = "Academics", action = "Correculum" });

                //endpoints.MapControllerRoute(
                //    name: "About",
                //    pattern: "About/{action}",
                //    defaults: new { controller = "About", action = "TheQuest" });

                //endpoints.MapControllerRoute(
                //      name: "default",
                //      pattern: "{action}",
                //      defaults: new { controller = "Home", action = "Index" });

                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapDefaultControllerRoute();

            });
        }
    }
}
