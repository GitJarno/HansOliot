using System;
using static System.Console;

namespace UsingInterfaces
{
    class Airplane : IMachine
    {
        private IMachine _engine1;
        private IMachine _engine2;

        public Airplane()
        {
            _engine1 = new AirplaneRotor();
            _engine2 = new AirplaneRotor();
        }

        public bool Start()
        {
            WriteLine("Engine 1 turning on.");
            bool m1 = _engine1.Start();
            WriteLine("Engine 2 turning on.");
            bool m2 = _engine2.Start();
            return (m1 && m2);
        }

        public bool Stop()
        {
            WriteLine("Stopping engine 1.");
            bool m1 = _engine1.Stop();
            WriteLine("Stopping engine 2");
            bool m2 = _engine2.Stop();
            return (m1 && m2);
        }
    }
}
