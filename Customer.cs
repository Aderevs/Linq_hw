using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Linq_hw
{
    internal class Customer
    {
        public Customer(string name, string phoneNumber, string carModel)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("phoneNumber");
            }
            if (carModel == null)
            {
                throw new ArgumentNullException("carModel");
            }
            if (phoneNumber.Count() != 10 || !Regex.IsMatch(phoneNumber, @"^\d+$"))
            {
                throw new FormatException("invalid phone number");
            }

            Name = name;
            PhoneNumber = phoneNumber;
            CarModel = carModel;
        }
        public string CarModel { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
