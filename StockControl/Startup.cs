using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StockControl.Service;
using StockControl.Service.Repository;

namespace StockControl
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StockContext>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IItemService, ItemService>();
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            DatabaseSeeder.Seed(new StockContext()); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
