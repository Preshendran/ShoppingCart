using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NLog.Web;
using ShoppingCart.DataAccess;
namespace ShoppingCart
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);
      builder.Host.UseNLog();
      // Add services to the container.

      builder.Services.AddControllers();
      // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
      builder.Services.AddEndpointsApiExplorer();
      builder.Services.AddSwaggerGen();
      
      builder.Services.AddDbContext<ShoppingCartContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ShoppingCart")));

      var app = builder.Build();

      // Configure the HTTP request pipeline.
      if (app.Environment.IsDevelopment())
      {
        app.UseSwagger();
        app.UseSwaggerUI();
      }

      app.UseAuthorization();


      app.MapControllers();

      app.Run();
    }
  }
}