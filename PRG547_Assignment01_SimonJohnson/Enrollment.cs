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

        public List<Course> Courses = new List<Course>();

        // Constructor
        public Enrollment(DateTime dateEnrolled, string grade, string semester)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public string GetCourses()
        {
            string returnCourses = "Courses: ";
            foreach (Course course in Courses) 
            {
                returnCourses += course.ToString() + "\n";
            }
            return returnCourses; 
        }

        public override string ToString()
        {
            return $"Date Enrolled: {DateEnrolled}\nGrade: {Grade}\nSemester: {Semester}\n{GetCourses()}";
        }

    }
}
