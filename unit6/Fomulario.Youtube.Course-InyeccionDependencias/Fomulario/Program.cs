using Fomulario.Repositorio;
using Fomulario.Repositorio.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fomulario
{
    internal static class Program
    {
        public static int Id_counter { get; set; } = 0;

        public static IServiceProvider ServiceProvider {  get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<Form2>());

        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.AddTransient<IClienteDatos, ClienteDatos>();
                services.AddTransient<IProductoDatos, ProductoDatos>();
                services.AddTransient<Form2>();
                services.AddTransient<FormEditar>();
            });
        }
    }
}