using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using The_World.Services;


namespace The_World
{
    public class Startup
    {

        // This is the place what is added to read configurations for the mail service 
        // !!!!
        public static IConfiguration Configuration;
        public Startup(IApplicationEnvironment appEnv)
        {
            var builder = new ConfigurationBuilder(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();              // this allows us to add different sources of configuration
               
            Configuration = builder.Build();
        }





        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services, IWebHostEnvironment env)
        {
            services.AddMvc();
            if (env.IsDevelopment())
            {
                services.AddScoped<IMailService, DebugMailService>();
            }
            //else 
            //{
            //    services.AddScoped<IMailService, RealMailService>();
            //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

           

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World");
                //});    

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=App}/{action=Index}/{id?}"
                    );

            });
        }
    }
}
