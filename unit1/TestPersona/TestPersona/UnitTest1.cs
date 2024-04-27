using TestPersona.Entities;

namespace TestPersona
{
    public class UnitTest1
    {
        [Fact]
        public void FullName_test()
        {
            Person person = new Person();
            person.Name = "Jane";
            person.LastName = "Doe";

            Assert.Equal("Jane Doe", person.FullName);
        }
        [Fact]
        public void FullName_test2()
        {
            Person person = new Person();
            person.Name = "Jane";
            person.LastName = "Doe";

            Assert.Equal("Jane Doe", person.FullName2());
        }

        [Fact]
        public void NameDoesEndsWithZero_test()
        {
            Person person = new Person();
            person.Name = "Jane00";
            person.LastName = "Doe";

            Assert.True(person.ReturnNameEndsWithDoubleZero());
        }
        [Fact]
        public void NameDoesNotEndsWithZero_test()
        {
            Person person = new Person();
            person.Name = "Jane";
            person.LastName = "Doe";

            Assert.False(person.ReturnNameEndsWithDoubleZero());
        }
        // Theory
        [Theory]
        [InlineData("Marie",false)]  // name , result
        [InlineData("Marie00",true)] // name , result
        public void TheoryNameEndsWithZero(string name, bool result)
        {
            Person person = new Person();
            person.Name = name;


            Assert.Equal(person.ReturnNameEndsWithDoubleZero(), result);
        }

    }
}