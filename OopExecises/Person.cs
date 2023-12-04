using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExecises
{
    internal class Person
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            } 
        }

        public Address Address { get; set; }
    }
}
