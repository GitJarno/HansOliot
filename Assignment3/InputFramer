using System;
using static System.Console;

namespace InputFramer
{
    class Program
    {
        static void PrintFramed(string text, char character)
        {
            int amount = text.Length;
            for (int i = -2; i <= amount; i++)
            {
                Write(character);

            }
            WriteLine("\n" + character + " " + text + " " + character);

            for (int j = -3; j <= amount; j++)
            {
                Write(character);

            }
            WriteLine("\n \n");
        }

        static void PrintWithSpaces(string text)
        {
            for (int i = 1; i <= text.Length; i += 1)
            {
                text = text.Insert(i, " ");
                i++;
            }

            WriteLine(text);
            ReadLine();
        }

        static void Main(string[] args)
        {

            WriteLine("Give input");
            string text = ReadLine();

            WriteLine("Give a character");
            char character = ReadKey().KeyChar;

            PrintFramed(text, character);
            PrintWithSpaces(text);
        }
    }
}
