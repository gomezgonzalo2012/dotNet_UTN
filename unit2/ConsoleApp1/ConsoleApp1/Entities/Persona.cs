using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Persona
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; }
        public string LastName { get; set; } 

        public string FullName
        {
            get
            {
                return Name+" " + LastName;
            }

        }
    }
}
