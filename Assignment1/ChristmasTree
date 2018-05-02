using System;
using static System.Console;

namespace ChristmasTree
{
    class Program
    {
        public static void ChristmasTree(int size)
        {
            for (int i = 0; i < size; i++)
            {
                printSpaces(size - i);
                printStars(i + 1 + i);
            }
               printTrunk(size -1);
               ReadKey();
        }

        public static void printSpaces(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Write(" ");
            }
            amount++;
        }

        public static void printStars(int lkm)
        {
            for (int i = 0; i < lkm; i++)
            {
                Write("*");
            }
            WriteLine();
            lkm--;
        }

        public static void printTrunk(int trunk)
        {
            for (int i = 0; i < trunk; i++)
            {
                Write(" "); 
            }
            Write("***"+ "\n");

            for (int j = 0; j < trunk; j++)
            {
                Write(" ");
            }
            Write("***");
        }

        static void Main(string[] args)
        {
            ChristmasTree(10);
        }
    }
}
