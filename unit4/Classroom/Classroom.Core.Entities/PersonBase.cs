using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public abstract class PersonBase // will only be inherited not intenced
    {
        public virtual int AgeCalc(DateOnly birthDate) // virtual means that its not an intance method an may be override
        {
            var today =  DateOnly.FromDateTime(DateTime.Now);
            var age = today.Year -birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;

        }
    }
}
