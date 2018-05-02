using System;
using static System.Console;

namespace Harjoitus4_Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            IMachine car = new Car();
            IMachine lawnmover = new Lawnmover();
            IMachine airplane = new Airplane();

            Start(car);
            Start(lawnmover);
            Start(airplane);
            Start(airplane);
            Shutdown(car);
            Shutdown(lawnmover);
            Shutdown(airplane);
            ReadKey();
        }
        static void Start(IStartable machine)
        {
            machine.Start();
        }
        static void Shutdown(IStoppable machine)
        {
            machine.Stop();
        }
    }
}
