using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class TemperatureConversion
    {
        public static void Conversion()
        {

            int celsius, faren;
           
                 Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
                 celsius = int.Parse(Console.ReadLine());
                 faren = (celsius * 9) / 5 + 32;
                 Console.WriteLine("0Temperature in Fahrenheit is(°F) : " + faren);
                  
            }
    }
}
