﻿using MyVet.WEB.Data;

namespace MyVet.WEB
{
   public class Startup
   {
      public Startup(IConfiguration configuration)
      {
         Configuration= configuration;
      }
      public IConfiguration Configuration { get; }

      public void ConfigureServices(IServiceCollection services)
      {
         // Add services to the container.
         services.AddControllersWithViews();

         services.AddDbContext<DataContext>(cfg =>
         {
           cfg.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
         });

      }
      public void Configure(WebApplication app, IWebHostEnvironment environment)
      {
         // Configure the HTTP request pipeline.
         if (!app.Environment.IsDevelopment())
         {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
         }

         app.UseHttpsRedirection();
         app.UseStaticFiles();

         app.UseRouting();

         app.UseAuthorization();

         app.MapControllerRoute(
             name: "default",
             pattern: "{controller=Home}/{action=Index}/{id?}");

      }
   }
}
