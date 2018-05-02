using System;
using static System.Console;

namespace A1_T2
{
    class Program
    {
        public static void PrintTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i + 1);
            }
            ReadKey();
        }

        public static void PrintSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Write(" ");
            }
            amount++;
        }

        public static void PrintStars(int lkm)
        {
            for (int j = 0; j < lkm; j++)
            {
                Write("*");
            }
            WriteLine();
            lkm--;
        }

        static void Main(string[] args)
        {
            PrintTriangle(4);
        }
    }
}
