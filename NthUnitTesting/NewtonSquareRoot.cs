using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class NewtonSquareRoot
    {
        public static void ReadInput()
        {
            double l = 0.00001, num, root, x, count = 0;
            Console.WriteLine("Enter number to be Root");
            num = Convert.ToInt32(Console.ReadLine());

            x = num;

            while (true)
            {
                count++;
                root = 0.5 * (x + (num / x));
                if (Math.Abs(root - x) < l)
                    break;
                x = root;
            }
            Console.WriteLine(root);

        }
    }
}
