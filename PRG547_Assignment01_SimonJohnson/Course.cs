using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Cost { get; set; }


        // Constructor
        public Course(string courseCode, string courseName, string cost) 
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
        }
    }
}
