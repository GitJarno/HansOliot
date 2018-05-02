using System;
using static System.Console;

/*Missing redundancy*/
namespace Harjoitus4_Tehtava4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Give the number of floors: ");
            int floor, floors = int.Parse(ReadLine());
            Elevator elevator = new Elevator(floors);
            elevator.ShowFloors();
            do
            {
                Write("Give a floor: ");
                floor = int.Parse(ReadLine());
                elevator.GoTo(floor);
            } while (floor != 1);

            ReadLine();
        }
    }
}
