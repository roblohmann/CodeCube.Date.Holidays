using System;

namespace CodeCube.Date.Holidays.CC
{
    public static class HolidayCalculator
    {
        public static DateTime CalculateEaster(int year)
        {
            var a = year - (year / 19) * 19;
            var b = year / 100;
            var c = year - (b * 100);
            var d = b / 4;
            var e = b - d * 4;
            var f = (b + 8) / 25;
            var g = (b - f + 1) / 3;
            var z = 19 * a + b - d - g + 15;
            var h = z - (z / 30) * 30;
            var i = c / 4;
            var k = c - i * 4;
            z = 32 + 2 * e + 2 * i - h - k;
            var l = z - (z / 7) * 7;
            var m = (a + 11 * h + 22 * l) / 451;
            z = h + l - 7 * m + 114;
            var n = z / 31;
            var p = z - n * 31;

            var day = p + 1;
            var month = n;

            return new DateTime(year, month, day);
        }
    }
}
