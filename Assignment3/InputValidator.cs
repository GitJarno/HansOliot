using System;
using static System.Console;

namespace InputValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            days day;
            do
            {
                Write("Give a number between 1 and 7: ");
                string input = ReadLine();
                try
                {
                    bool ifNumber = int.TryParse(input, out int temp);
                    int number = temp;
                    if (!ifNumber)
                    {
                        throw new Exception("Not an integer.");
                    }
                    if (temp < 1 || 7 < temp)
                    {
                        throw new Exception("The number is not between 1 and 7.");
                    }
                    else
                    {
                        day = (days)number;
                        WriteLine($"Number {number} is equivelant of {day}");
                        break;
                    }
                }
                catch (Exception e)
                {
                   WriteLine(e.Message);
                }
            } while (true);
            ReadKey();
        }
        public enum days { Monday = 1, Tuesday, Wednesday, Thurday, Friday, Saturday, Sunday }
    }
}
