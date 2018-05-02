using System;
using static System.Console;

namespace UsingInterfaces
{
    class AirplaneRotor : IMachine
    {
        private bool _started;

        public bool Start()
        {
            if (_started == false)
            {
                _started = true;
                WriteLine("Airplane rotor started.");
            }
            else
            {
                WriteLine("Wasn't started. A rotor was already turned on");
            }
            return _started;
        }

        public bool Stop()
        {
            if (_started == true)
            {
                _started = false;
                WriteLine("Airplane engine turned off.");
            }
            else
            {
                WriteLine("Wasn't started because there is no airplane engine that's on.");
            }
            return !_started;
        }
    }
}
