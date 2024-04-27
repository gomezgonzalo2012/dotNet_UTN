using Person.Core.Entities;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            h1.Name = "Jane";
            h1.LastName = "Doe";
            h1.Age = 30;

            Console.WriteLine($"Name: {h1.Name} {h1.LastName} Age: {h1.Age}");
        }
    }
}
