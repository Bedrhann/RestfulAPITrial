using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bedirhan_Hafta_2.Extensions
{
    static public class DateTimeExtensions
    {
        static public string Ago(this DateTime dateTime)
        {
            DateTime NowTime = DateTime.Now;
            TimeSpan Span = NowTime - dateTime;
            int Minute = (int)Span.TotalMinutes;
            int Year = 0, Month = 0, Day = 0, Hour = 0;
            if (Minute > 525960)
            {
                Year = Minute / 525960;
                Minute = Minute % 525960;
            }
            if (Minute > 43200)
            {
                Month = Minute / 43200;
                Minute = Minute % 43200;
            }
            if (Minute > 1440)
            {
                Day = Minute / 1440;
                Minute = Minute % 1440;
            }
            if (Minute > 60)
            {
                Hour = Minute / 60;
                Minute = Minute % 60;
            }
            string a = Year.ToString() + " yıl " + Month.ToString() + " ay " + Day.ToString() + " gün " + Hour.ToString() + " saat " + Minute.ToString() + " dakika önce";
            return a;
        }
    }
}
