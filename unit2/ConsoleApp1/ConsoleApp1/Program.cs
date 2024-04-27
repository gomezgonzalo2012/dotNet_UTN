using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // using the namesace to instance an object
            ConsoleApp1.Entities.Persona person1;
            Persona person2;

            // person1, person2 = new Persona(); // X WRONG!

            person1 = new Persona();
            person2 = new Persona();

            // CONTROL STRUCTURES

            // if - else
            Console.WriteLine("Enter an Id for person 1");
            var id = Console.ReadLine();
            person1.Id = Int32.Parse(id);
            if (person1.Id == 18)
            {
                Console.WriteLine("Congratulations you have won an amazin prize!!!");
            }
            else
            {
                Console.WriteLine("Sorry, better luck next time");
            }
            
            Console.WriteLine("Enter a Name for person 2");
            person2.Name = Console.ReadLine();
            // switch-case

            switch (person2.Name.ToLower())
            {
                case "marta":
                    Console.WriteLine($"{person2.Name} your son is looking for you");
                    break;
                case "john":
                    Console.WriteLine($"Hi {person2.Name}!");
                    break;
                case "luna":
                    Console.WriteLine($"Hi {person2.Name}!, how was your weekend?");
                    break;
                default: 
                    break;
            }

            // for - foreach

            Queue<Persona> myQueue = new Queue<Persona>();

            for(int i = 0; i< 10 ; i++)
            {
                myQueue.Enqueue(new Persona()
                {
                    Name= $"Persona {i}",
                    
                });

            }

            while( myQueue.GetEnumerator().MoveNext()) // Allow iterate the queue while it is being modified
            {
                Console.WriteLine(myQueue.Dequeue().Name);
            }

        }
    }
}
