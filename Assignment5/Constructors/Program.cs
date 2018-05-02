using System;
using static System.Console;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                FirstName = "Olli",
                LastName = "Oppija",
                DateOfBirth = new DateTime(1995, 03, 25)
            },
             student2 = new Student()
             {
                 FirstName = "Maira",
                 LastName = "Malli",
                 DateOfBirth = new DateTime(1996, 11, 2)
             };

            WriteLine(  $"{student1.Id} {student1.Name}, {student1.Age}" + 
                        $"\n{student2.Id} {student2.Name}, {student2.Age}"
                     );

            ReadKey();

        }
    }
}

