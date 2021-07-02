using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class MonthlyPayments
    {
        public static void ReadInput()
        {
            double years, p, RateOfIntrest;

            //getting year from user
            Console.WriteLine("Enter the number of years");
            years = Convert.ToDouble(Console.ReadLine());

            //Getting Principle amount from user
            Console.WriteLine("Enter the Principle amount");
            p = Convert.ToDouble(Console.ReadLine());

            //Getting rate of intrest from user
            Console.WriteLine("Enter the rate of interest");
            RateOfIntrest = Convert.ToDouble(Console.ReadLine());

            MonthlyPaymentIs(years, p, RateOfIntrest);
        }
        private static void MonthlyPaymentIs(double years, double p, double RateOfIntrest)
        {
            double m = 12 * years;
            double r = RateOfIntrest / (12 * 100);
            double x = Math.Pow(1 + r, m);
            double payment = (p * r * x) / (x - 1);

            Console.WriteLine($"Monthly Payment is = {Math.Round(payment)}");
        }
    }
}
