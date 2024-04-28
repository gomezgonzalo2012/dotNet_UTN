using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class Student : Person
    {
        public Student() { }

        public Student(string firstName) 
            : base(firstName) // use the base abstract methos that have the same firm 
        {
            
            //FirstName = firstName;
            //base.FirstName = firstName;

        }

        public override string ToDo() 
        {
            return $"{base.ToDo() } by Student"; // uses the implementation in the base class + this class
        }

        // same name diffrent firms
        public string Study(string demo)
        {
            return $"ok {demo}";
        }

        public string Study(bool demo)
        {
            return $"ok {demo}";
        }
    }
}
