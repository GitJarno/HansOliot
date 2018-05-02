using System;
using static System.Console;

namespace A2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOutcome(7);
            PrintOutcome(123445628999773);
            PrintOutcome(88);
            ReadKey();
        }

        private static void PrintOutcome(long longValue)
        {
            int newNumber;
            Boolean success = LongToInt(longValue, out newNumber);

            if (success == true)
            {
                WriteLine("Conversion succesful!",
                     newNumber);
            }
            else
            {
                WriteLine("Conversion unsuccesful!",
                      newNumber);
            }

        }

        private static Boolean LongToInt(long longValue, out int intValue)
        {

            if (longValue >= Int32.MinValue && longValue <= Int32.MaxValue)
            {
                intValue = Convert.ToInt32(longValue);
                return true;
            }
            else
            {
                intValue = 0;
                return false;
            }
        }
    }
}
