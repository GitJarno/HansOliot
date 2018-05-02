using System;
using static System.Console;

namespace Dice
{
    class dice
    {
        private int _number, _throwamount;
        private double _counter;

        public dice()
        {
            _number = -1;
            _throwamount = 0;
            _counter = 0;
        }

        public void Throw()
        {
            Random r = new Random();
            _number = r.Next(1, 7);
            _throwamount++;
            _counter += _number;
        }

        public int ShowResult() { return _number; }

        public int ShowThrowAmount() { return _throwamount; }

        public double Cumulative() { return _counter; }
    }
}
