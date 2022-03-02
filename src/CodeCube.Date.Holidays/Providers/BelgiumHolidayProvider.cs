using System;
using System.Collections.Generic;
using System.Linq;
using CodeCube.Date.Holidays.CC;
using CodeCube.Date.Holidays.DTO;

namespace CodeCube.Date.Holidays.Providers
{
    internal sealed class BelgiumHolidayProvider : IHolidayProvider
    {
        public List<PublicHolidayDTO> GetHolidays(int year)
        {
            var list = new List<PublicHolidayDTO>();

            if (year < 1600)
                return list;

            var eastern = HolidayCalculator.CalculateEaster(year);
            var referenceDate = eastern.AddDays(-2);


            var holiday = new PublicHolidayDTO(new DateTime(year, 1, 1), "Nieuwjaarsdag", true);
            list.Add(holiday);

            referenceDate = referenceDate.AddDays(2);
            holiday = new PublicHolidayDTO(referenceDate, "1e Paasdag", true);
            list.Add(holiday);

            referenceDate = referenceDate.AddDays(1);
            holiday = new PublicHolidayDTO(referenceDate, "2e Paasdag", true);
            list.Add(holiday);

            holiday = new PublicHolidayDTO(new DateTime(year, 5, 1), "Dag van de Arbeid", false);
            list.Add(holiday);

            referenceDate = referenceDate.AddDays(38);
            holiday = new PublicHolidayDTO(referenceDate, "Hemelvaart", false);
            list.Add(holiday);

            referenceDate = referenceDate.AddDays(10);
            holiday = new PublicHolidayDTO(referenceDate, "1e Pinksterdag", false);
            list.Add(holiday);

            referenceDate = referenceDate.AddDays(1);
            holiday = new PublicHolidayDTO(referenceDate, "2e Pinksterdag", false);
            list.Add(holiday);


            holiday = new PublicHolidayDTO(new DateTime(year, 7, 21), "Nationale feestdag", true);
            list.Add(holiday);

            holiday = new PublicHolidayDTO(new DateTime(year, 8, 15), "Onze-Lieve-Vrouw Hemelvaart", true);
            list.Add(holiday);


            holiday = new PublicHolidayDTO(new DateTime(year, 11, 1), "Allerheiligen", true);
            list.Add(holiday);


            holiday = new PublicHolidayDTO(new DateTime(year, 11, 11), "Wapenstilstand", true);
            list.Add(holiday);

            holiday = new PublicHolidayDTO(new DateTime(year, 12, 25), "1e Kerstdag", false);
            list.Add(holiday);

            holiday = new PublicHolidayDTO(new DateTime(year, 12, 26), "2e Kerstdag", false);
            list.Add(holiday);

            return list.OrderBy(h => h.Day).ToList();
        }


    }
}
