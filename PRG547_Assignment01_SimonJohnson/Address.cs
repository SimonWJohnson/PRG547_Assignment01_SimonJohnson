using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class Address
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        // Constructor
        public Address(string number, string street, string suburb, string postcode, string state)
        {
            Number = number;
            Street = street;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        // ToString
        public override string ToString()
        {
            return $"Number: {Number}\nStreet: {Street}\nSuburb: {Suburb} \nPostcode: {Postcode}\nState : {State}";
        }
    }
}
