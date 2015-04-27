using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Birthday
    {


        static void Main(string[] args)
        {
            Birthday b = new Birthday();

            b.displayCurrentDateAndTime();

            DateTime d = new DateTime(2016, 02, 01); //yyyy-mm-dd
            Console.WriteLine("Your birthday is on {0} , day is {1} ",d, d.DayOfWeek);   
            b.findBirthDayInYear(d,2023);
        }

        public void displayCurrentDateAndTime()
        {
            Console.WriteLine("Today's current date and time is  "+ DateTime.Now);
        }

        public void findBirthDayInYear(DateTime date, int year)
        {
            DateTime newDate = date.AddYears(year - date.Year);
            Console.WriteLine("Your birthday in year {0} will be on {1}",year,newDate.DayOfWeek);

        }

    }
}
