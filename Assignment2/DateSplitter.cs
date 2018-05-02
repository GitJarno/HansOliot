using System;
using static System.Console;

/*DISCLAIMER: No exception handling or input validation*/
namespace DateSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            WriteLine("Give a date:");
            userInput = ReadLine();
            WriteLine("The date split:");

            string[] split = userInput.Split('.');
            WriteLine("Year = " + split[2]);
            WriteLine("Month = " + split[1]);
            WriteLine("Day = " + split[0]);

            ReadLine();
        }
    }
}
