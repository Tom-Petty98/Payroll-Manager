using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Payroll_Manager.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Payroll_Manager.Services;
using Payroll_Manager.Services.Implementation;

namespace Payroll_Manager
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
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();


            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //Default Password Settings
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                //Default Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
            });

            services.AddControllersWithViews();
            services.AddRazorPages();


            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPayComputationService, PayComputationService>();
            services.AddScoped<INationalInsuranceContributionService, NationalInsuranceContributionService>();
            services.AddScoped<ITaxService, TaxService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
                              IWebHostEnvironment env, 
                              UserManager<IdentityUser> userManager, 
                              RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            DataSeedingIntializer.UserAndRoleSeedAsync(userManager, roleManager).Wait();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
