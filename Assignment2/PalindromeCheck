using System;
using System.Linq;
using static System.Console;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Give a string: ");
            string given = ReadLine();

            if (palindromeCheck(given))
            {
                WriteLine("The input was a palindrome");
            }
            else
            {
                WriteLine("The input was not a palindrome.");
            }
            ReadLine();
        }

        static string reverse(string given)
        {
            return new string(given.Reverse().ToArray());
        }

        static string removeSpaces(string given)
        {

            var removeCharacters = new string[] {" ",".",":",";",",","!","?"};
            foreach (var character in removeCharacters)
            {
                given = given.Replace(character, string.Empty);
            }
            return given.ToString();

        }
        static bool palindromeCheck(string given)
        {
            if (removeSpaces(reverse(given)) == removeSpaces(given))
            {
                return true;
            }
            return false;
        }
    }
}
