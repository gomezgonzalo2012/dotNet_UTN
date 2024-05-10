using PracticingIDClases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingIDClases
{
    public class WorkerWithDI
    {
        private readonly IMessageWriter _messageWriter;
        public WorkerWithDI(IMessageWriter messageWriter) { 
            _messageWriter = messageWriter;
        }
        public void DoSomeWork()
        {
            _messageWriter.Write($"Worker running at: {DateTimeOffset.Now}");

        }
    }
}
