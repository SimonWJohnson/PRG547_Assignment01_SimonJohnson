using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547_Assignment01_SimonJohnson
{
    public class Enrollment
    {
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }

        public string Semester { get; set; }

        public Course Course { get; set; }

        // Constructor
        public Enrollment(DateTime dateEnrolled, string grade, string semester)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
        }

        public void AddCourse(Course course)
        {
            Course = Course;
        }


    }
}
