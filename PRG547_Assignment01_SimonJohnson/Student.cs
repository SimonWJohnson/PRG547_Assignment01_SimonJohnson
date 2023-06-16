using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class Student : Person
    {
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        // Constructor
        public Student(string name, string email, string telNum, string program, DateTime dateRegistered): base(name, email, telNum) 
        {
            Program = program;
            DateRegistered = dateRegistered;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nEmail: {Email}\nTelNum: {TelNum} Program: {Program}\nDate Registered: {DateRegistered}";
        }

        public override void DisplayPerson()
        {
            Console.WriteLine($"Name: {Name}\nEmail: {Email}\nTelNum: {TelNum}");
            Console.WriteLine($"Program: {Program}\nDate Registered: {DateRegistered}");
        }
    }
}
