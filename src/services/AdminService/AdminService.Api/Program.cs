using Ocelot.DependencyInjection;
using Ocelot.Middleware;
namespace AdminService.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

// Загрузка конфигурации Ocelot из файла
            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// Регистрация Ocelot
            builder.Services.AddOcelot();

            var app = builder.Build();

            app.UseOcelot().Wait();

            app.Run();
        }
    }
}
