using System;
using static System.Console;

namespace Constructors
{
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Name { get; }
    }
}
