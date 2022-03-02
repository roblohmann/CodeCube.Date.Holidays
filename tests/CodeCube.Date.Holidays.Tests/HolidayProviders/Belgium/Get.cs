using System;
using CodeCube.Date.Holidays.CC;
using Xunit;

namespace CodeCube.Date.Holidays.Tests.HolidayProviders.Belgium
{
    public class Get
    {
        [Fact]
        public void Holidays_For_2021_Succeeds()
        {
            //Setup
            const int year = 2022;
            var holidayProvider = HolidayProviderFactory.GetHolidayProvider(CountryCode.BE);

            //Act
            var holidays = holidayProvider.GetHolidays(year);

            //Assert
            Assert.NotNull(holidays);
            Assert.Equal(13, holidays.Count);
            Assert.Equal(new DateTime(2022,1,1), holidays[0].Day);
            Assert.Equal(new DateTime(2022,4,17), holidays[1].Day);
            Assert.Equal(new DateTime(2022,4,18), holidays[2].Day);
            Assert.Equal(new DateTime(2022,5,1), holidays[3].Day);
            Assert.Equal(new DateTime(2022,5,26), holidays[4].Day);
            Assert.Equal(new DateTime(2022,6,5), holidays[5].Day);
            Assert.Equal(new DateTime(2022,6,6), holidays[6].Day);
            Assert.Equal(new DateTime(2022,7,21), holidays[7].Day);
            Assert.Equal(new DateTime(2022,8,15), holidays[8].Day);
            Assert.Equal(new DateTime(2022,11,1), holidays[9].Day);
            Assert.Equal(new DateTime(2022,11,11), holidays[10].Day);
            Assert.Equal(new DateTime(2022,12,25), holidays[11].Day);
            Assert.Equal(new DateTime(2022,12,26), holidays[12].Day);
        }
    }
}
