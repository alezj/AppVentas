using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

     

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(day, month, year);
        }

        private int CheckDay(int day, int month, int year)
        {
            if (month ==2 && day == 29 &&  IsLeapYear(year))
            {
                return day;
            }
            int[] dayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >=1 && day <=dayPerMonth[month] )
            {
                return day;
            }

            throw new DayException("Este dia es invalido:"+ day);
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0; 
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <=12)
            {
                return month;
            }

            throw new MonthException($"Mes errado");
        }

        public override string ToString()
        {
            return $"{_day:00}/{_month:00}/{_year}";
        }
    }
}
