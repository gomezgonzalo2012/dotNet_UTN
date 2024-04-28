using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class TeacherTest
    {
        [Fact]
        public void Should_create_a_Teacher()
        {
            var teacher = new Teacher();
            teacher.FirstName = "Mateo";
            teacher.BirthDate =  DateOnly.FromDateTime( DateTime.Now);

            Assert.True("Mateo"==teacher.FirstName);
            Assert.Equal(0, teacher.Age);
            Assert.Equal("ToDo", teacher.ToDo());


        }
    }
}
