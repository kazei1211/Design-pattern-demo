using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Address
    {
        public string City { get; set; }

        public Address(string city)
        {
            City = city;
        }
    }
}
