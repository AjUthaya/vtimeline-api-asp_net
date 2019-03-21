using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;

namespace vtimeline
{
    public class Startup
    {
        // DEFINE: Variable
        public IConfigurationRoot Configuration { get; set; }

        // CONSTRUCTOR
        public Startup(IHostingEnvironment env)
        {
            // 1. DEFINE: Setup configuration/s
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config/Application.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"config/Application.{env.EnvironmentName}.json", optional: true);

            // 2. DEFINE: Build configuration object
            Configuration = builder.Build();
        }


        // CONFIGURE: Services
        public void ConfigureServices(IServiceCollection services)
        {
            // 1. REGISTER: Configuration
            services.Configure<configModel>(Configuration.GetSection("ApplicationConfig"));

            // 2. REGISTER: MVC and set .NET core compatibility version
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // 3. REGISTER: CORS for API
            services.AddCors(options =>
           {
               options.AddPolicy("AllowAllOrigins",
                   builder =>
                   {
                       builder
                           .AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                   });
           });
        }


        // CONFIGURE: Application
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // 1. IF: Development
            if (env.IsDevelopment())
            {
                // A. ENABLE: Developer friendly error page
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // A. ENABLE: SSL enforcement
                app.UseHsts();
            }

            // 2. ENABLE: HTTP to HTTPS redirect
            app.UseHttpsRedirection();

            // 3. ENABLE: MVC as default handler
            app.UseMvc();
        }
    }
}
