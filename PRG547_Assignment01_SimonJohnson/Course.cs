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
        public double Cost { get; set; }


        // Constructor
        public Course(string courseCode, string courseName, double cost) 
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Cost = cost;
        }

        public static bool operator == (Course a, Course b)
        {
            return object.Equals(a, b);
        }

        public static bool operator != (Course a, Course b)
        {
            return !object.Equals(a, b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (ReferenceEquals(obj, this))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Course course = obj as Course;
            return this.CourseCode == course.CourseCode;
        }

        public override int GetHashCode()
        {
            return this.CourseCode.GetHashCode();
        }

        public override string ToString()
        {
            return $"Course Code: {CourseCode}\nCourse Name: {CourseName}\nCost: {Cost}";
        }
    }
}
