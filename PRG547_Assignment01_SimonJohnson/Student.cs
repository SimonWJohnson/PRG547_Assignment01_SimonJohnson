using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class Student : Person, IComparable<Student>
    {
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        // Constructor
        public Student(string name, string email, string telNum, string program, DateTime dateRegistered): base(name, email, telNum) 
        {
            Program = program;
            DateRegistered = dateRegistered;
        }

        // Equals
        public static bool operator == (Student a, Student b) 
        {
            return object.Equals(a, b);
        }
        public static bool operator != (Student a, Student b) 
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
            Student stu = obj as Student;
            return this.Email == stu.Email && this.DateRegistered == stu.DateRegistered;
        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode() ^ this.DateRegistered.GetHashCode();
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

        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.GetHashCode().CompareTo(other.GetHashCode());
        }


    }
}
