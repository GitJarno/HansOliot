using System;
using static System.Console;

namespace Constructors
{
    class Student : IId, IPerson
    {
        static int LastUsedId = 0;
        private DateTime _DateOfBirth;

        public Student()
        {
            LastUsedId++;
            this.Id = LastUsedId;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get => $"{FirstName} {LastName}"; }

        public DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set => _DateOfBirth = value;
        }

        public int Age
        {
            get => (int)((DateTime.Now - _DateOfBirth).TotalDays / 365);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
