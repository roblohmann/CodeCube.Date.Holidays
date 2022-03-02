using System;
using CodeCube.Date.Holidays.CC;
using CodeCube.Date.Holidays.Providers;

namespace CodeCube.Date.Holidays
{
    public static class HolidayProviderFactory
    {
        public static IHolidayProvider GetHolidayProvider(CountryCode countryCode)
        {
            return GetPublicHolidays(countryCode);
        }

        private static IHolidayProvider GetPublicHolidays(CountryCode countryCode)
        {
            switch (countryCode)
            {
                case CountryCode.AF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AX:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.DZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AQ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BB:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BE:
                    return new BelgiumHolidayProvider();
                case CountryCode.BZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BJ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BQ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BV:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CV:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CX:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.HR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.DK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.DJ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.DM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.DO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.EC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.EG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SV:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GQ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ER:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.EE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ET:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.FK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.FO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.FJ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.FI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.FR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.DE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GP:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.HT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.HM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.HN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.HK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.HU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ID:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IQ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.IT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.JM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.JP:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.JE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.JO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KP:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LV:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LB:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MV:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ML:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MQ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.YT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MX:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.FM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ME:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NP:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NL:
                    return new DutchHolidayProvider();
                case CountryCode.NC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MP:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.NO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.OM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.QA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.RE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.RO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.RU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.RW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.BL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.KN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.MF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.PM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.WS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ST:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.RS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SX:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SB:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ZA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SS:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ES:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.LK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SD:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SJ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.CH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.SY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TJ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TL:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TK:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TO:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TT:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TR:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TC:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.TV:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.UG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.UA:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.AE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.GB:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.US:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.UM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.UY:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.UZ:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VU:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VN:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VG:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.VI:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.WF:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.EH:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.YE:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ZM:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                case CountryCode.ZW:
                    throw new NotImplementedException($"CountryCode {countryCode} hasn't been implemented yet.");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(countryCode), countryCode, null);
            }
        }
    }
}
