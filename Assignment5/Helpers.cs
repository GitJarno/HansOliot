using System;
using static System.Console;

namespace Helpers
{
    public static class Input
    {
        public static int Integer(string input, int min = int.MinValue, int max = int.MaxValue)
        {
            Write(input);
            bool success = int.TryParse(ReadLine(), out int integer);
            if (!success)
            {
                throw new Exception("Input is not an integer.");
            }
            else if (integer < min || integer > max)
            {
                throw new Exception($"Input was not a valid integer. Smallest integer is {min} and highest is {max}.");
            }
            else
            {
                return integer;
            }
        }

        public static double Decimal(string input, int accuracy = -1)
        {
            Write(input);
            bool success = double.TryParse(ReadLine(), out double @decimal);

            if (success)
            {
                @decimal = (accuracy > -1) ? Math.Round(@decimal, accuracy) : @decimal;
                return @decimal;
            }
            else
            {
                throw new Exception("Input is not a valid integer..");
            }
        }

        public static char Character(string input)
        {
            Write(input);
            bool Success = char.TryParse(ReadLine(), out char character);

            if (Success)
            {
                return character;
            }
            else
            {
                throw new Exception("Input is not a valid character.");
            }
        }

        public static string Merkkijono(string input)
        {
            Write(input);
            return ReadLine();
        }

        public static DateTime date(string input)
        {
            Write(input);
            bool success = DateTime.TryParse(ReadLine(), out DateTime date);
            return (success) ? date : throw new Exception("Input was not a valid date.");
        }

        public static int IntegerByForce(string input, int min = int.MinValue, int max = int.MaxValue)
        {
            do
            {
                try
                {
                    return Integer(input, min, max);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
        }

        public static double DecimalByForce(string input, int accuracy = -1)
        {
            do
            {
                try
                {
                    return Decimal(input, accuracy);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
        }

        public static DateTime DateByForce(string input)
        {
            do
            {
                try
                {
                    return date(input);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
        }
    }
}
