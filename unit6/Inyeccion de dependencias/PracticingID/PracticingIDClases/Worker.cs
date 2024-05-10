//using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingIDClases
{
    public class Worker //: BackgroundService
    {
        private readonly MessageWriter _messageWriter = new();

        public void DoSomeWork()
        {
              _messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");

        }
        //protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        //{
        //    while (!stoppingToken.IsCancellationRequested)
        //    {
        //        _messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");
        //        await Task.Delay(1_000, stoppingToken);
        //    }
        //}
    }
}
