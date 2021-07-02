using System;
using System.Collections.Generic;
using System.Text;

namespace NthUnitTesting
{
    class VendingMachine
    {
        public static void PrintingNotes()
        {
            Console.WriteLine("enter amount");
            int number = Convert.ToInt32(Console.ReadLine());
            MinNotes(number);
        }
        private static void MinNotes(int amount)
        {
            int[] notes = { 2000, 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] notecount = new int[notes.Length];

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    notecount[i] = amount / notes[i];
                    amount = amount - (notecount[i] * notes[i]);
                    if (amount <= 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("Currency Count");
            for (int i = 0; i < notes.Length; i++)
            {
                if (notecount[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : " + notecount[i]);
                }
            }
        }
    }
}
