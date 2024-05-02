using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Howarts.App.Entities.Tests
{
    public class DateTimeTest
    {
        [Fact]
        public void Initialize_a_datetime()
        {
            DateTime dt = new();
            Assert.Equal(1, dt.Day);
            Assert.Equal(1, dt.Month);
            Assert.Equal(1, dt.Year);
            Assert.Equal("1/1/0001 00:00:00", dt.ToString()); // the begginnin of times

        }
        [Fact]
        public void Using_substract_generate_a_timeSpan()
        {
            var date1 = new DateTime(2000,12,12);
            var date2 = new DateTime(2010,2,23);

            TimeSpan ts = date2.Subtract(date1);

            var years = ts.TotalDays / 365; // calculate years
            Assert.True(years >= 9);
        }

        [Theory]
        [InlineData(3,3)]
        public void Uses_of_addMinutes(int times, int expectedHoures)
        {
            DateTime dateTime = new DateTime(2000,1,1);
            for(int i = 0; i < times; i++)
            {
                dateTime.AddHours(1);
            }

            Assert.Equal(expectedHoures, dateTime.Hour);

        }

        [Fact]
        public void toString_method()
        {
            DateTime date1 = new DateTime(2000, 3, 2, 12,0, 0);
            Assert.Equal("2/3/2000 12:00:00", date1.ToString());
        }

        [Fact]

    }
}
