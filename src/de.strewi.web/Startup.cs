using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using de.strewi.web.Models;
using de.strewi.web.Services;
using de.strewi.database;
using de.strewi.database.Models;
using Microsoft.AspNetCore.Identity;

namespace de.strewi.web
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            if (env.IsDevelopment())
            {
                // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
                builder.AddUserSecrets();
            }

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, Role>(ai => 
                ai.User.RequireUniqueEmail = true)
                .AddEntityFrameworkStores<ApplicationDbContext, Guid>()
                .AddDefaultTokenProviders()
                .AddUserStore<UserStore<ApplicationUser, Role, ApplicationDbContext, Guid>>()
                .AddRoleStore<RoleStore<Role, ApplicationDbContext, Guid>>();

            services.AddMvc();

            // Add application services.
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseIdentity();

            //Seed a default user into the system
            var userManager = app.ApplicationServices.GetService<UserManager<ApplicationUser>>();
            var roleManager = app.ApplicationServices.GetRequiredService<RoleManager<Role>>();
            var sysUser = userManager.FindByEmailAsync("yan.kun0567@gmail.com").Result;

            if (sysUser == null)
            {

                var userResult = userManager.CreateAsync(new ApplicationUser
                {
                    Id = Guid.Parse("A514CA05-8087-4A63-A378-89C938F55290"),
                    Email = "yan.kun0567@gmail.com",
                    EmailConfirmed = true,
                    UserName = "yan.kun0567",
                    Firstname = "System",
                    Lastname = "User",
                    MemberNumber = 000,
                    IsActivated = true,
                    RegisteredAt = DateTime.UtcNow
                }, "strongPassword17!").Result;

                sysUser = userManager.FindByEmailAsync("yan.kun0567@gmail.com").Result;
            }

            if (!roleManager.RoleExistsAsync(Role.ROLE_SUPERADMIN).Result)
            {
                roleManager.CreateAsync(new Role
                {
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Role.ROLE_SUPERADMIN,
                    Id = Guid.Parse("F8BF9E0B-1F0E-409F-81ED-6234C3C1EDB1")
                });
            }

            if (userManager.GetRolesAsync(sysUser).Result.Count == 0)
            {
                userManager.AddToRoleAsync(sysUser, Role.ROLE_SUPERADMIN);
            }
            //Add the rest of the roles too

            if (!roleManager.RoleExistsAsync(Role.ROLE_ADMIN).Result)
            {
                roleManager.CreateAsync(new Role
                {
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Role.ROLE_ADMIN,
                    Id = Guid.Parse("9B36237D-5EEC-411A-B989-8793512EADB2")
                });
            }

            if (!roleManager.RoleExistsAsync(Role.ROLE_MODERATOR).Result)
            {
                roleManager.CreateAsync(new Role
                {
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Role.ROLE_MODERATOR,
                    Id = Guid.Parse("634D8386-938E-4DD3-9AFB-83E677B30987")
                });
            }

            if (!roleManager.RoleExistsAsync(Role.ROLE_USER).Result)
            {
                roleManager.CreateAsync(new Role
                {
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    Name = Role.ROLE_USER,
                    Id = Guid.Parse("5F15F698-F808-4466-A63F-89DECA408083")
                });

            }
            // Add external authentication middleware below. To configure them please see http://go.microsoft.com/fwlink/?LinkID=532715

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "admin",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Search}/{action=Index}/{id?}");
            });
        }
    }
}
