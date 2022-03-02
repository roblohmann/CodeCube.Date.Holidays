using System.Collections.Generic;
using CodeCube.Date.Holidays.DTO;

namespace CodeCube.Date.Holidays
{
    public interface IHolidayProvider
    {
        /// <summary>
        /// Get the holidays for the provided year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        List<PublicHolidayDTO> GetHolidays(int year);
    }
}