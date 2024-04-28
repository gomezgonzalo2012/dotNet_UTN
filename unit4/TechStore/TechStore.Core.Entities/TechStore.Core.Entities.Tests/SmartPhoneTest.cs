using TechStore.Core.Entities;
namespace TechStore.Core.Entities.Tests
{
    public class SmartPhoneTest
    {
        [Fact]
        public void Should_create_an_smartphone()
        {
            SmartPhone smart = new();
            smart.Id = "1";
            smart.Created= DateOnly.FromDateTime(DateTime.Now);

            Assert.NotNull(smart);

        }

        [Theory]
        [InlineData(10f,13f)] // + 30%
        [InlineData(20f,26f)] // + 30%
        public void Shoul_calculate_the_Price(float buyPrice, float expectedPrice )
        {
            var smart = new SmartPhone(buyPrice);
            Assert.Equal(expectedPrice, smart.Price);
        }

        [Fact]
        public void Should_print_revision_method()
        {
            SmartPhone smart = new();
            Assert.Equal("SmartPhone in revision...", smart.Revision());
        }

        [Fact]
        public void Should_calculate_the_expirationDate()
        {
            SmartPhone smart = new();
            smart.Created= DateOnly.FromDateTime(DateTime.Now);

            Assert.Equal("2026", smart.ExpirationDate().Year.ToString()); // only compare the years
            
        }
    }
}