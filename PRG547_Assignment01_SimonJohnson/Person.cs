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

        // Constructor
        public Person(string name, string email, string telNum) 
        {
            Name = name;
            Email = email;
            TelNum = telNum;
        }

        // Abstract method
        public abstract void DisplayPerson();
    }
}
