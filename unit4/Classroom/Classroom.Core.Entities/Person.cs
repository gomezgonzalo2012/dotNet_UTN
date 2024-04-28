using Classroom.Core.Entities.Interfaces;

namespace Classroom.Core.Entities
{
    public abstract class Person : PersonBase, IPerson, IWithFirstNameAndLastName

    {

        // may change any of these methods
        public int Age {// DIFFER from the interface
            get {
               return base.AgeCalc(BirthDate); // calls the method in the inherit class PersonBase
            }
        }

        public override int AgeCalc(DateOnly birthDate) 
        {
            return base.AgeCalc(birthDate) - 2;
        }

        public DateOnly BirthDate { get ; set ; }

        private string? _firstName;
        public string FirstName // DIFFER from the interface
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get ; set ; }


        public string FullName
        {
            get { 
                return $"{FirstName} {LastName}";

            }
        }

        // 3 diffrent constructors
        public Person() { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName)
        {
            FirstName = firstName;
            LastName = string.Empty;
        }
        public virtual string ToDo() // ALLOWS AN IMPLEMENTATION
        {
            return "ToDo";
        }

        //public abstract string ToDo()  // IMPLEMENTATION NOT ALLOWED 
        //{
        //    return "ToDo";
        //}

        public override string ToString()
        {
            return FullName;
        }

    }
}
