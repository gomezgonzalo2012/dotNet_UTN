namespace Classroom.Core.Entities.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Should_create_a_student()
        {
            // Arrange
            Student student = new Student();
            // Act
            student.FirstName = "Paolo";
            student.LastName = "Rivera";
            // Assert
            Assert.Equal("Paolo", student.FirstName);
            Assert.Equal("Rivera", student.LastName);
        }

        [Fact]
        public void Should_call_toDo_method()
        {
            Student student = new Student();
            Assert.Equal("ToDo by Student",student.ToDo());    
        }

        [Fact]
        public void Should_create_a_student_with_no_lastName()
        {
            // Arrange
            Student student = new Student("Jane");
            // Assert
            Assert.Equal("Jane", student.FirstName);
            Assert.Equal(string.Empty, student.LastName);
        }

        [Theory]
        [InlineData(2000,3,2,24)]
        [InlineData(1985,9,5,38)]
        public void Should_create_a_student_set_Birthdate_return_Age(int year, int month, int day, int expectedAge)
        {
            // Arrange
            Student student = new Student();
            student.BirthDate = new DateOnly(year, month, day);
            // Assert
            Assert.Equal(expectedAge, student.Age);
            
        }
    }
}