using System.Security.AccessControl;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("Enter any key and see magic");
            string? input = Console.ReadLine();
           for (int i = 0;i<5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(input);
                    
                }
                Console.WriteLine(" ");
            }
        }
    }
}
