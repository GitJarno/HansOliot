using System;
using static System.Console;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            dice dice1 = new dice();
            dice1.Throw();
            WriteLine("Dice landed on: " + dice1.ShowResult());

            do
            {
                Write("Throw again? (yes/no)");
                string input = ReadLine();
                try
                {
                    if (input == "yes")
                    {
                        dice1.Throw();
                        WriteLine("Dice landed on: " + dice1.ShowResult());
                    }
                    else if (input == "no")
                    {
                        WriteLine("Amount of throws " + dice1.ShowThrowAmount());
                        WriteLine("Average of throws is " + dice1.Cumulative() / dice1.ShowThrowAmount());
                        break;
                    }
                    else
                    {
                        throw new Exception("Bad input");
                    }
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (1 < 2);
            ReadLine();
        }
    }
}
