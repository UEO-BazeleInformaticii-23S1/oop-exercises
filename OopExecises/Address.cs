using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExecises
{
    internal class Address
    {
        public Address(
            string country,
            string county,
            string city,
            string streetName,
            string streetNumber) 
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentNullException(nameof(country));
            }

            // or alternatively
            // ValidateNotNullOrEmpty(country, nameof(country));

            if (string.IsNullOrWhiteSpace(county))
            {
                throw new ArgumentNullException(nameof(county));
            }

            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentNullException(nameof(city));
            }

            if (string.IsNullOrWhiteSpace(streetName))
            {
                throw new ArgumentNullException(nameof(streetName));
            }

            if (string.IsNullOrWhiteSpace(streetNumber))
            {
                throw new ArgumentNullException(nameof(streetNumber));
            }

            Country = country;
            County = county;
            City = city;
            StreetName = streetName;
            StreetNumber = streetNumber;
        }

        public string Country { get; }

        public string County { get; } 

        public string City { get; }

        public string StreetName { get; }

        public string StreetNumber {  get; }

        private static void ValidateNotNullOrEmpty(string parameterValue, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameterValue))
            {
                throw new ArgumentNullException(nameof(parameterName));
            }
        }
    }
}
