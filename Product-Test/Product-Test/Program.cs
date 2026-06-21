using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Product_Test.Data;
namespace Product_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Product_TestContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Product_TestContext") ?? throw new InvalidOperationException("Connection string 'Product_TestContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
