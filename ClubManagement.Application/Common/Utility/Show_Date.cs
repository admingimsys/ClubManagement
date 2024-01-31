using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Application.Common.Utility
{
    public static class Show_Date
    {
        public static string showdate(DateTime data, Boolean shortdate)
        {
            string[] week = { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه" };
            string[] months = { "فرودین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
            short d = 0;

            DateTime a = data;
            DayOfWeek tempdayofweek = a.DayOfWeek;
            switch (tempdayofweek)
            {
                case DayOfWeek.Saturday: d = 0; break;
                case DayOfWeek.Sunday: d = 1; break;
                case DayOfWeek.Monday: d = 2; break;
                case DayOfWeek.Tuesday: d = 3; break;
                case DayOfWeek.Wednesday: d = 4; break;
                case DayOfWeek.Thursday: d = 5; break;
                case DayOfWeek.Friday: d = 6; break;
            }
            int day = int.Parse(a.Day.ToString());
            int month = int.Parse(a.Month.ToString());
            int year = int.Parse(a.Year.ToString());

            year = (year == 0) ? 2000 : year;

            if (year < 1000)
            { year += 2000;/*:true;*/}
            year -= ((month < 3) || ((month == 3) && (day < 21))) ? 622 : 621;
            switch (month)
            {
                case 1: if (day < 21) { month = 10; day += 10; } else { month = 11; day -= 20; } break;
                case 2: if (day < 20) { month = 11; day += 11; } else { month = 12; day -= 19; } break;
                case 3: if (day < 21) { month = 12; day += 9; } else { month = 1; day -= 20; } break;
                case 4: if (day < 21) { month = 1; day += 11; } else { month = 2; day -= 20; } break;
                case 5: if (day < 21) { month = 2; day += 11; } else { month = 3; day -= 20; } break;
                case 6: if (day < 22) { month -= 3; day += 10; } else { month -= 2; day -= 21; } break;
                case 7: if (day < 21) { month = 3; day += 11; } else { month = 4; day -= 20; } break;
                case 8: if (day < 21) { month = 4; day += 11; } else { month = 5; day -= 20; } break;
                case 9: if (day < 23) { month -= 3; day += 9; } else { month -= 2; day -= 22; } break;
                case 10: if (day < 23) { month = 7; day += 8; } else { month = 8; day -= 22; } break;
                case 11: if (day < 21) { month = 8; day += 9; } else { month = 9; day -= 21; } break;
                case 12: if (day < 22) { month -= 3; day += 9; } else { month -= 2; day -= 21; } break;
                default: break;
            }
            if (shortdate != true)
            {
                return (week[d] + " " + day + " " + months[month - 1] + " " + year);
            }
            else
            {
                string smonth = "", sday = "";
                if (month >= 1 && month <= 9)
                {
                    smonth = "0" + month.ToString();
                }
                else
                {
                    smonth = month.ToString();
                }

                if (day >= 1 && day <= 9)
                {
                    sday = "0" + day.ToString();
                }
                else
                {
                    sday = day.ToString();
                }
                return (year + "/" + smonth + "/" + sday);
            }
        }
        public static string showtime()
        {
            return DateTime.Now.ToLongTimeString().ToString();
        }
        public static string ToPersianDateString(DateTime georgianDate)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();



            string[] week = { "شنبه", "یکشنبه", "دوشنبه", "سه شنبه", "چهارشنبه", "پنجشنبه", "جمعه" };
            string[] months = { "فرودین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }

        public static DateTime converpersianNumber(string date)
        {
            System.Globalization.PersianCalendar faDate = new System.Globalization.PersianCalendar();
            string converpersianNumber = date.Replace("۰", "0").Replace("۱", "1").Replace("۲", "2").Replace("۳", "3").Replace("۴", "4").Replace("۵", "5").Replace("۶", "6").Replace("۷", "7").Replace("۸", "8").Replace("۹", "9");
            string[] ConvertNumberSplit = converpersianNumber.Split('/');
            DateTime DateConvete = faDate.ToDateTime(Convert.ToInt32(ConvertNumberSplit[0]), Convert.ToInt32(ConvertNumberSplit[1]), Convert.ToInt32(ConvertNumberSplit[2]), 0, 0, 0, 0);

            return DateConvete;
        }


        public static string showdate(DateTime? dateRegister)
        {
            throw new NotImplementedException();
        }

    }
}
