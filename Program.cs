using Microsoft.EntityFrameworkCore;
using Pronia1Business.Services.Abstracts;
using Pronia1Business.Services.Concretes;
using Pronia1Core.RepositoryAbstracts;
using Pronia1Data.DAL;
using Pronia1Data.RepositoryConcretes;

namespace Pronia1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>

           options.UseSqlServer(builder.Configuration.GetConnectionString("cString"))

           );








            builder.Services.AddScoped<IFeatureService, FeatureService>();
            builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IFeatureRepository, FeatureRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ISliderService, SliderService>();
            builder.Services.AddScoped<ISliderRepository, SliderRepository>();


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