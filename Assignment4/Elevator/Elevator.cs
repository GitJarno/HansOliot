using System;
using static System.Console;

namespace Elevator
{
    class Elevator
    {
        private bool _doorsOpen;
        private int _floor, _topFloor;

        public Elevator(int floors)
        {
            _topFloor = floors;
            _doorsOpen = false;
            _floor = 1;
        }

        public void GoTo(int floor)
        {
            if (floor > _floor)
            {
                MoveUp(floor);
            }
            else
            {
                MoveDown(floor);
            }
        }

        private void MoveUp(int floor)
        {
            CloseDoors();
            while (floor > _floor && floor <= _topFloor && floor > 0)
            {
                _floor++;
                ShowFloors();
            }
            OpenDoors();
        }

        private void MoveDown(int floor)
        {
            CloseDoors();
            while (floor < _floor && floor <= _topFloor && floor > 0)
            {
                _floor--;
                ShowFloors();
            }
            OpenDoors();
        }

        private void OpenDoors()
        {
            _doorsOpen = true;
            WriteLine("Doors are open.");
        }

        private void CloseDoors()
        {
            _doorsOpen = false;
            WriteLine("Doors are closed.");
        }

        public void ShowFloors()
        {
            for (int i = 1; i <= _topFloor; i++)
            {
                if (i == _floor)
                {
                    Write($"[{i}] ");
                }
                else
                {
                    Write(i + " ");
                }
            }
            WriteLine();
        }
    }
}
