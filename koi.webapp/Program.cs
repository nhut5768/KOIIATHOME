using koi.respositories;
using koi.respositories.Entities;
using koi.respositories.Interfaces;
using koi.services;
using koi.services.Interfaces;

namespace koi.webapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<KoiFishManagementDbContext>();
            builder.Services.AddScoped<IArticleRespository, ArticleRespository>();
            builder.Services.AddScoped<IArticleService, ArticleService>();
            //DI 
            builder.Services.AddScoped<IFeedCalculationRespository, FeedCalculationRespository>();
            builder.Services.AddScoped<IFeedCalculationService, FeedCalculationService>();
            builder.Services.AddScoped<IFishRespository, FishRespository>();
            builder.Services.AddScoped<IFishService, FishService>();

            builder.Services.AddScoped<IOrderRespository, OrderRespository>();
            builder.Services.AddScoped<IOrderService, OrderService>();
            builder.Services.AddScoped<IPondRespository, PondRespository>();
            builder.Services.AddScoped<IPondService, PondService>();
            builder.Services.AddScoped<ISaltCalculationRespository, SaltCalculationRespository>();
            builder.Services.AddScoped<ISaltCalculationService, SaltCalculationService>();
            builder.Services.AddScoped<IWaterParameterRespository, WaterParameterRespository>();
            builder.Services.AddScoped<IWaterParameterService, WaterParameterService>();

            builder.Services.AddRazorPages();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}

