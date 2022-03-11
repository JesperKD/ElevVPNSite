using ElevVPNBlazorWebsite.Data.Providers;
using ElevVPNBlazorWebsite.Data.Services;
using ElevVPNClassLibrary.Core.Database.Managers;
using ElevVPNClassLibrary.Core.Settings;
using ElevVPNClassLibrary.Extensions.ServiceCollection;
using ElevVPNClassLibrary.Security.Cryptography;
using ElevVPNClassLibrary.Security.Cryptography.Hashing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ElevVPNBlazorWebsite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionSettings = Configuration.GetSection("ElevVPN:DB").Get<DbConnectionSettings>();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddSingleton<IConnectionSettings>(connectionSettings);

            services.AddFactories();

            services.AddSingleton<ISqlDbManager, SqlDbManager>();
            //services.AddTransient<ICryptographyService, HashingService>();

            services.AddManagers();

            services.AddRepositories();

            services.AddEntityServices();
            services.AddScoped<IRefreshProvider, RefreshProvider>();
            services.AddScoped<PaginationService>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
