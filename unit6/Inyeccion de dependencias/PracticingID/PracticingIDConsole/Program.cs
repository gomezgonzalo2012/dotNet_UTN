using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PracticingIDClases;
using PracticingIDClases.Interfaces;

namespace PracticingIDConsole
{
    public class Program
    {
        //public static IServiceProvider ServiceProvider { get; private set; }

        static void Main(string[] args)
        {
            
            //Worker worker = new Worker();
            //worker.DoSomeWork();

            var host = CreateHostBuilder().Build();

            var worker = host.Services.GetRequiredService<WorkerWithDI>();
            worker.DoSomeWork();


            
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                //services.AddTransient<IMessageWriter, MessageWriter>();
                services.AddTransient<IMessageWriter, MessageWriter2>();
                services.AddTransient<WorkerWithDI>();
            });
        }
    }
}
