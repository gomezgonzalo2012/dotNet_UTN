using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Core.Entities
{
    public class Course
    {
        public string? Title { get; set; }
        public Teacher? Teacher { get; set; }

        public List<Student> Students { get; set; } //= new List<Student>(); // same

        public Course()
        {
            Students = new List<Student>(); // same
        }

        public Course(string? title, Teacher? teacher)
        {
            Title = title;
            Teacher = teacher;
        }

        public void Add(Student student) // one student at a time
        {
            Students.Add(student);
        }

        public void Add(List<Student> students) // a list of student at a time
        {
            Students.AddRange(students);
        }
    }
}
