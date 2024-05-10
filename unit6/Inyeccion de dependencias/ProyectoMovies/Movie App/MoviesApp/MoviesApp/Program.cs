using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoviesApp.Entities.Repository;

namespace MoviesApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Inyeccion de dependencias
            var host = CreateHostBuider().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Principal>());
        }

        static IHostBuilder CreateHostBuider()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddTransient<IMovieDatos, MovieDatos>();
                services.AddTransient<IIdiomaDatos, IdiomaDatos>();
                services.AddTransient<Principal>();
            });
        }
    }
}