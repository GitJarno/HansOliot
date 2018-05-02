using System;
using static System.Console;

namespace UsingInterfaces
{
    public class Lawnmover : IMachine
    {
        bool IStartable.Start()
        {
            WriteLine("Lawnmover started");
            return true;
        }

        bool IStoppable.Stop()
        {
            WriteLine("Lawnmower shutdown");
            return true;
        }
    }
}
