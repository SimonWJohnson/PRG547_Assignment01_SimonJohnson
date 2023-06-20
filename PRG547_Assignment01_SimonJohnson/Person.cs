using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNum { get; set; }
        public Address Address { get; set; }

        // Constructor
        public Person(string name, string email, string telNum, string number, string street, string suburb, string postcode, string state) 
        {
            Name = name;
            Email = email;
            TelNum = telNum;
            Address address = new Address(number, street, suburb, postcode, state);
        }

        // Abstract method
        public abstract void DisplayPerson();

        public void setAddress(string number, string street, string suburb, string postcode, string state)
        {
            Address = new Address(number, street, suburb, postcode, state);
        }
    }
}
