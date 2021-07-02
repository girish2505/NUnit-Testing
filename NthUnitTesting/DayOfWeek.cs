using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class DayOfWeek
    {
        public static void ReadInput()
        {
            int d, m, y;

            //get date from user
            Console.WriteLine("Enter the date");
            d = Convert.ToInt32(Console.ReadLine());
            //get month from user
            Console.WriteLine("Enter the Month");
            m = Convert.ToInt32(Console.ReadLine());
            //get year from user
            Console.WriteLine("Enter the year");
            y = Convert.ToInt32(Console.ReadLine());


            FindDayOfWeek(d, m, y);


        }
        private static void FindDayOfWeek(int d, int m, int y)
        {
            //array for days of week
            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //calculating day of week by given georgian formula
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            //printing output
            Console.WriteLine($"The day on this {d}-{m}-{y} date is {daysOfWeek[d0]} ");
        }
    }
}
