using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities.Tests
{
    public class CourseTest
    {
        [Fact]
        public void Should_create_a_course_with_teacher_and_students()
        {
            // Arrange
            var course = new Course();
            //Act
            for (int i = 0; i < 10; i++)
            {
                var stu= new Student($"student {i}");

                course.Add( stu );
            }
            //Assert
            Assert.Equal(10, course.Students.Count());
            Assert.True(course.Students[0].FirstName == "student 0");
        }
        [Fact]
        public void Shoul_create_set_a_course_with_a_range_of_Student()
        {
            // Arrange
            var course = new Course();
            List<Student> students = new List<Student>();
            // Act
            for (int i = 0; i < 10; i++)
            {
                var stu = new Student($"student {i}");

                students.Add(stu);
            }

            course.Add(students); // add the whole list
            // Assert
            Assert.Equal(10, course.Students.Count());
            Assert.True(course.Students[0].FirstName == "student 0");
        }
    }

}
