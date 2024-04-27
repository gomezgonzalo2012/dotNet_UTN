namespace Unit3.Core.Entities.Tests
{
    public class PetTest
    {
        [Fact]
        public void Should_create_a_notNull_pet()
        {
            var dog = new Pet();
            //dog.BirthDay = new DateOnly(2000,3,3);
            dog.BirthDay= new (2000,3,3);

            Assert.NotNull(dog);
            Assert.Equal(string.Empty, dog.Name); // nombre sin setTear
           // Assert.Equal(string.Empty, dog.Breed); // raza sin settear
        }

        [Fact]
        public void Should_return_the_age()
        {
            var dog = new Pet()
            {
                Name = "Maia",
                Breed = "Chihuahua",
                BirthDay = new(2023, 4, 27)
            };

            Assert.Equal(1, dog.Age());
        }

        [Theory]
        [InlineData(2020,4,4,4)]
        [InlineData(2020, 7, 4,3)]
        public void Should_return_the_age2(int year, int month, int days, int ageExpected)
        {
            var cat = new Pet()
            {
                BirthDay = new(year, month, days)
            };

            Assert.Equal(ageExpected, cat.Age());
        }

    }
}