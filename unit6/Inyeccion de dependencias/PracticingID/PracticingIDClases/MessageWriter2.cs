using PracticingIDClases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticingIDClases
{
    public class MessageWriter2 : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine($"This is your message {message}");
        }
    }
}
