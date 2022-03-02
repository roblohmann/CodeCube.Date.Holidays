using System;
using CodeCube.Date.Holidays.CC;
using Xunit;

namespace CodeCube.Date.Holidays.Tests.DateFactory
{
    public class Get
    {
        [Fact]
        public void With_CountryCode_NL_Succeeds()
        {
            //Setup

            //Act
            var holidayProvider = HolidayProviderFactory.GetHolidayProvider(CountryCode.NL);

            //Assert
            Assert.NotNull(holidayProvider);
        }

        [Fact]
        public void With_UnknownCountry_Fails()
        {
            //Setup

            //Act + assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                HolidayProviderFactory.GetHolidayProvider(CountryCode.Unknown)
            );
        }
    }
}