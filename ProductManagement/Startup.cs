using Microsoft.AspNetCore.Builder;
using ProductManagement.Infrastructure.IRepository;
using ProductManagement.Infrastructure.Repository;

namespace ProductManagement
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllersWithViews();
            //services.AddSingleton<IDapperServices, DapperServices>();
            services.AddTransient<ICategory, ICategory>();


        }
    }
}
