using CodeCube.Date.Holidays.CC;
using Xunit;

namespace CodeCube.Date.Holidays.Tests.HolidayProviders.Dutch
{
    public class Get
    {
        [Fact]
        public void Holidays_For_2021_Succeeds()
        {
            //Setup
            const int year = 2022;
            var holidayProvider = HolidayProviderFactory.GetHolidayProvider(CountryCode.NL);

            //Act
            var holidays = holidayProvider.GetHolidays(year);

            //Assert
            Assert.NotNull(holidays);
            Assert.Equal(10, holidays.Count);
        }
    }
}
