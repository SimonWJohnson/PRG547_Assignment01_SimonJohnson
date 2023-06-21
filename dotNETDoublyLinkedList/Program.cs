using PRG547_Assignment01_SimonJohnson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNETDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //***********************************************************************************************************************************************//
            //Testing the DoublyLinkedList
            DoublyLinkedList<Student> studentList = new DoublyLinkedList<Student>();
            Course course1 = new Course("PRG547", "C Sharp", 100.00);
            studentList.Add(new Student("Simon", "simon@email.com", "08 555 6667", "100", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.AddLast(new Student("Jesse", "jesse@email.com", "08 555 7777", "101", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.AddLast(new Student("Andre", "Andre.email.com", "08 555 8888", "102", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.AddLast(new Student("Jamie", "jamie@email.com", "08 555 6667", "107", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.AddLast(new Student("Noah", "Noah.email.com", "08 555 9999", "103", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));

            foreach (Student student in studentList)
            {
                student.DisplayPerson();
            }
            Console.ReadLine(); // This was a weird one :(

            studentList.RemoveLast();
            foreach (Student student in studentList)
            {
                student.DisplayPerson();
            }
            Console.ReadLine();

            // ToString
            foreach (Student student in studentList)
            {
                string studentInfo = student.ToString();
                Console.WriteLine(studentInfo);
            }
            Console.ReadLine();

            //Get HashCode()
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.GetHashCode());
            }
            Console.WriteLine(studentList.Count);
            Console.ReadLine();

            // Instantiate new instance of Utility
            Utility tools = new Utility();
            tools.BubbleSortAsc<Student>(studentList);

            foreach (Student student in studentList)
            {
                Console.WriteLine(student.GetHashCode()); // Get each HashCode from the student list
            }
            Console.ReadLine();

            tools.BubbleSortDesc<Student>(studentList);
            foreach (Student student in studentList)
            {
                Console.WriteLine(student.GetHashCode()); // Get each HashCode from the student list
            }
            Console.ReadLine();


            Student Simon = new Student("Simon", "simon@email.com", "08 555 6667", "100", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            Student Jamie = new Student("Jamie", "jamie@email.com", "08 555 6667", "107", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            DoublyLinkedListNode<Student> nl = tools.BinarySearch<Student>(studentList, Jamie);
            DoublyLinkedListNode<Student> nl2 = tools.SequentialSearch<Student>(studentList, Jamie);
            Console.WriteLine(nl.Value);
            Console.WriteLine(nl2.Value);
            Console.ReadLine();


            //********************************************************************************************************************************************************//
            // Testing the LinkedList
            PRG547_Assignment01_SimonJohnson.LinkedList<Student> studentList2 = new PRG547_Assignment01_SimonJohnson.LinkedList<Student>();
            Course course2 = new Course("PRG547", "C Sharp", 100.00);
            Course course3 = new Course("PRG666", "KTs", 666.66);
            studentList2.Add(new Student("Simon", "simon@email.com", "08 555 6667", "100", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList2.AddLast(new Student("Jesse", "jesse@email.com", "08 555 7777", "101", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList2.AddLast(new Student("Andre", "Andre.email.com", "08 555 8888", "102", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList2.AddLast(new Student("Noah", "Noah.email.com", "08 555 9999", "103", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));

            // Testing the singleBinarySearch
            tools.SingleBubbleSortAsc<Student>(studentList2);
            Student test = tools.SingleBinarySearch<Student>(studentList2, new Student("Andre", "Andre.email.com", "08 555 8888", "102", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            Console.WriteLine(test);
            Console.ReadLine();

            // AddCourse Method
            Student jamie = new Student("jamie", "jamie@email.com", "08 555 8888", "104", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            jamie.Enrollment.AddCourse(course3);
            Console.WriteLine(jamie);
            Console.ReadLine();

            foreach (Student student in studentList2)
            {
                student.DisplayPerson();
            }
            Console.ReadLine(); // This was a weird one :(

            studentList2.RemoveLast();
            foreach (Student student in studentList2)
            {
                student.DisplayPerson();
            }
            Console.ReadLine();

            foreach (Student student in studentList2)
            {
                string studentInfo = student.ToString();
                Console.WriteLine(studentInfo);
            }
            Console.ReadLine();

            //****************************************************************************************************************************************************************************************//


        }


    }
}
