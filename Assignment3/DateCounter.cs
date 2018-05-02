using System;
using static System.Console;

namespace DateCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fi-fi");
            DateTime today = DateTime.Today;
            do
            {
                Write("Give a date: ");
                string input = ReadLine();
                try
                {
                    bool success = DateTime.TryParse(input, out DateTime compare);
                    if (!success)
                    {
                        throw new Exception("Input was not a date");
                    }
                    else
                    {
                        int difference = (today - compare).Days;
                        string a = (string)today.ToShortDateString();
                        string b = (string)compare.ToShortDateString();
                        WriteLine($"Between the days of {a} and {b}, there are {Math.Abs(difference)} days.");
                        break;
                    }
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (true);
            ReadLine();
        }
    }
}
