using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using finanzas.Data;
using finanzas.Models;
using finanzas.Services;

namespace finanzas
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>(
                cfg =>
                {
                    /// solo un correo por usuario
                    cfg.User.RequireUniqueEmail = true;

                    /// bajar las opciones de password
                    cfg.Password.RequireDigit = false;
                    cfg.Password.RequiredLength = 3;
                    cfg.Password.RequireNonAlphanumeric = false;
                    cfg.Password.RequireLowercase = false;
                    cfg.Password.RequireUppercase = false;



                }
            )
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {


            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
            app.UseStaticFiles();

            /// 
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
