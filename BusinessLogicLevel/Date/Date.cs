using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BusinessLogicLevel
{
    public class Date:IDateLogic
    {
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        public Date()
        {
        }
        private Date(int Year, int Month, int Day, int Hour, int Minute)
        {
            if (Year > 2000 && Month >= 1 && Month <= 12 && Day <= 31 && Day >= 1 && Hour >= 0 && Hour < 23 && Minute >= 0 && Minute < 59)
            {
                year = Year;
                month = Month;
                day = Day;
                hour = Hour;
                minute = Minute;
            }
            else
            {
                Console.WriteLine("Nor correct date");
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
        public string Print_date()
        {
            string date = year.ToString() + "." + month.ToString() + "." + day.ToString() + "   " + hour.ToString() + ":" + minute.ToString() + "\n";
            return date;
        }
        public IDateLogic CreateDate(int Year, int Month, int Day, int Hour, int Minute)
        {
            IDateLogic temp = new Date(Year,Month,Day,Hour,Minute);
            return temp;
        }
    }
}