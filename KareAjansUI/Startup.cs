using KareAjans.Business.Abstract;
using KareAjans.Business.Concretes;
using KareAjans.Business.Mapper;
using KareAjans.DataAccess;
using KareAjans.DataAccess.Abstracts;
using KareAjans.DataAccess.Concretes;
using KareAjans.Entity.Enums;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KareAjans.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            //services.AddScoped<DataContext>(); eskisi

            // Inject DataContext
            services.AddDbContext<DataContext>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            #region Inject Repositories
            // Inject Repositories
            // private readonly olan proplara inject oluyor, Service/Manager kısmında kullanılıyor.
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<IExpenseTypeRepository, ExpenseTypeRepository>();
            services.AddScoped<IIncomeRepository, IncomeRepository>();
            services.AddScoped<IModelEmployeeOrganizationRepository, ModelEmployeeOrganizationRepository>();
            services.AddScoped<IModelEmployeeRepository, ModelEmployeeRepository>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IPictureRepository, PictureRepository>();
            services.AddScoped<IProfessionalDegreeRepository, ProfessionalDegreeRepository>();
            services.AddScoped<ISiteContentRepository, SiteContentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            #endregion


            #region Inject Services
            // Inject Services

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IExpenseService, ExpenseManager>();
            services.AddScoped<IExpenseTypeService, ExpenseTypeManager>();
            services.AddScoped<IIncomeService, IncomeManager>();
            services.AddScoped<IModelEmployeeService, ModelEmployeeManager>();
            services.AddScoped<IOrganizationService, OrganizationManager>();
            services.AddScoped<IPermissionService, PermissionManager>();
            services.AddScoped<IPictureService, PictureManager>();
            services.AddScoped<IProfessionalDegreeService, ProfessionalDegreeManager>();
            services.AddScoped<ISiteContentService, SiteContentManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAccountingService, AccountingManager>();
            #endregion

            //version 2 ve üzerinde mappingProfile ı göndermek zorundayız
            services.AddAutoMapper(typeof(MappingProfile));


            services.AddSession(options => 
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // Razor cdan sessiona erişmek istedik
            // https://stackoverflow.com/questions/46921275/access-session-variable-in-razor-view-net-core-2
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                //options.CheckConsentNeeded = context => true;
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //yetki tipleri belirlemek gerek
            
            services.AddAuthorization(config =>
            {
                config.AddPolicy(UserType.Administrator.ToString(), policyBuilder =>
                policyBuilder.RequireClaim(ClaimTypes.Role, UserType.Administrator.ToString()));

                config.AddPolicy(UserType.Accountant.ToString(), policyBuilder =>
                policyBuilder.RequireClaim(ClaimTypes.Role, new string[] { UserType.Administrator.ToString(), UserType.Accountant.ToString() }));

                config.AddPolicy(UserType.ModelEmployee.ToString(), policyBuilder =>
                policyBuilder.RequireClaim(ClaimTypes.Role, UserType.ModelEmployee.ToString()));
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Login/Login";
                options.LogoutPath = "/Login/Logout";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.AccessDeniedPath = "/Login/Login";
            });

            services.AddDistributedMemoryCache();
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
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default", "{controller=Home}/{action=index}/{id?}");
            });

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
                context.Database.Migrate();
            }
        }
    }
}
