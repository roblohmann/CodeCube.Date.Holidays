using System;

namespace CodeCube.Date.Holidays.DTO
{
    public sealed class PublicHolidayDTO
    {
        public PublicHolidayDTO(DateTime day, string description, bool isNationalHoliday)
        {
            Day = day;
            Description = description;
            IsNationalHoliday = isNationalHoliday;
        }

        /// <summary>
        /// The day.
        /// </summary>
        public DateTime Day { get; }

        /// <summary>
        /// The description / name for the day.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Is this day a national day off or not?
        /// </summary>
        public bool IsNationalHoliday { get; }
    }
}