using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Interfaces
{
    public interface IPerson : IWithFirstNameAndLastName
    {
        int Age {  get; }
        DateOnly BirthDate { get; set; }
        //string FirstName { get; set; }
        //string LastName { get; set; }

        string ToDo();
    }
}
