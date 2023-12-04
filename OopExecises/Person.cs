using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExecises
{
    internal class Person
    {
        public Person(
            string lastName,
            string firstName,
            DateTime dateOfBirth,
            Address address) 
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (address is null)
            {
                throw new ArgumentNullException(nameof(address));
            }

            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;  
            Address = address;
        }

        public string LastName { get; private set; }

        public string FirstName { get; private set; }

        public DateTime DateOfBirth { get; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            } 
        }

        public Address Address { get; private set; }

        public void Print()
        {
            Console.WriteLine($"{LastName} {FirstName}, date of birth: {DateOfBirth:yyyy-MM-dd}, age: {Age}");
            Console.WriteLine($"Address: {Address.StreetName} {Address.StreetNumber}, {Address.City}, {Address.County}, {Address.Country}");
        }
    }
}
