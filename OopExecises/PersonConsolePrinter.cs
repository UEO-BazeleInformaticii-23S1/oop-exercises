using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExecises
{
    internal static class PersonConsolePrinter
    {
        public static void Print(Person p)
        {
            if (p is null)
            {
                throw new ArgumentNullException(nameof(p));
            }

            Console.WriteLine($"{p.LastName} {p.FirstName}, date of birth: {p.DateOfBirth:yyyy-MM-dd}, age: {p.Age}");
            Console.WriteLine($"Address: {p.Address.StreetName} {p.Address.StreetNumber}, {p.Address.City}, {p.Address.County}, {p.Address.Country}");
        }
    }
}
