using System;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using pluto.rover.api.Orders;
using pluto.rover.domain.Exceptions;

namespace pluto.rover.api
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
      services.AddControllers();
      services.AddSingleton<IRoverOrders, RoverOrders>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseExceptionHandler(errorApp =>
      {
        errorApp.Run(async context =>
        {
          context.Response.ContentType = "text/plain";

          var exceptionHandlerPathFeature =
              context.Features.Get<IExceptionHandlerPathFeature>();

          if (exceptionHandlerPathFeature?.Error is FoundObstacleException foundObstacleException)
          {
            context.Response.StatusCode = (int)HttpStatusCode.OK;
            await context.Response.WriteAsync(foundObstacleException.Message);
          }
          else
          {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            await context.Response.WriteAsync("Internal server error");
          }
        });
      });

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
