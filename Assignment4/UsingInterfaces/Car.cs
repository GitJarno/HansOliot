using System;
using static System.Console;

namespace UsingInterfaces
{
    public class Car : IMachine
    {
        bool IStartable.Start()
        {
            WriteLine("Car started.");
            return true;
        }

        bool IStoppable.Stop()
        {
            WriteLine("Car stopped.");
            return true;
        }
    }
}
