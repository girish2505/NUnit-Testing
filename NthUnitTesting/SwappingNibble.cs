using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class SwappingNibble
    {
        public static void ReadInput()
        {
            int n;
            //geting input from user
            Console.WriteLine("Enter the decimal value");
            n = Convert.ToInt32(Console.ReadLine());

            ToBinary(n);

        }

        // Convert decimal to binary 
        private static void ToBinary(int n)
        {
            Console.WriteLine($"Decimal number before swapped = {n}");
            int binaryNumber = ((n & 0x0F) << 4 | (n & 0xF0) >> 4);

            Console.WriteLine($"Decimal number after swapped = {binaryNumber}");
            bool value = checkPower(binaryNumber);

            Console.WriteLine(value ? $"{binaryNumber} is power of two" : $"{ binaryNumber} is not power of two");
        }
        private static bool checkPower(int binaryNumber)
        {
            while (binaryNumber != 1)
            {
                if (binaryNumber % 2 != 0)
                    return false;

                binaryNumber /= 2;
            }
            return true;
        }
    }
}
