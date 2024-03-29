using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;

namespace HairSalon
{
  public class Startup
  {
    public Startup(IWebHostEnvironment env)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json"); //this line replaces .AddEnvironmentVariables();
        Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();

        //New code
        services.AddEntityFrameworkMySql()
            .AddDbContext<HairSalonContext>(options => options
            .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
    }
        //   public void ConfigureServices(IServiceCollection services)
        // {
        //     services.AddMvc();
        //     services.AddDbContext<HairSalonContext>(
        //         dbContextOptions => dbContextOptions
        //             .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], new MySqlServerVersion(ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])))
        //     );
        // }

    public void Configure(IApplicationBuilder app)
    {
      app.UseDeveloperExceptionPage();
      app.UseRouting();

      app.UseEndpoints(routes =>
      {
        routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
      });

      app.UseStaticFiles();
      
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}