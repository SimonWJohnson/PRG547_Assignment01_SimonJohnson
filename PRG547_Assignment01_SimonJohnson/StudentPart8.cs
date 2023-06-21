using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class StudentPart8 : Person, IComparable<StudentPart8>
    {
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        public Enrollment Enrollment { get; set; }

        // Constructor
        public StudentPart8(string name, string email, string telNum,
            string number, string street, string suburb, string postcode, string state,
            string program, DateTime dateRegistered,
            DateTime dateEnrolled, string grade, string semester)
            : base(name, email, telNum, number, street, suburb, postcode, state)
        {
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = new Enrollment(dateEnrolled, grade, semester);
        }

        // Equals
        public static bool operator ==(StudentPart8 a, StudentPart8 b)
        {
            return object.Equals(a, b);
        }
        public static bool operator !=(StudentPart8 a, StudentPart8 b)
        {
            return !object.Equals(a, b);
        }

        //Override the Equals() and GetHashCode()
        // Selected Email and DateRegistered as the two best choices for Hashing as Email is unique,
        // especially when combined with DateRegistered
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            StudentPart8 student = obj as StudentPart8;
            return this.Name.Equals(student.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}\nEmail: {Email}\nTelNum: {TelNum} \nProgram: {Program}\nDate Registered: {DateRegistered}\nEnrollment: {Enrollment}";
        }

        public override void DisplayPerson()
        {
            Console.WriteLine($"Name: {Name}\nEmail: {Email}\nTelNum: {TelNum}");
            Console.WriteLine($"Program: {Program}\nDate Registered: {DateRegistered}");
        }

        public int CompareTo(StudentPart8 other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.Name.CompareTo(other.Name);
        }

    }
}
