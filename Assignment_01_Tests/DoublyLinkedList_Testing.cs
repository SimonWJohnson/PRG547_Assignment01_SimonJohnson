using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PRG547_Assignment01_SimonJohnson;

namespace Assignment_01_Tests
{
    [TestFixture]
    class DoublyLinkedList_Testing
    {
        public PRG547_Assignment01_SimonJohnson.DoublyLinkedList<Student> studentList;
        public Student student1;

        [OneTimeSetUp]
        public void Init()
        {
            // Construct new Student
            Student student1 = new Student("Simon", "simon@email.com", "08 555 6667", "100", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");

            // Construct new Student List
            studentList = new PRG547_Assignment01_SimonJohnson.DoublyLinkedList<Student>();
            studentList.Add(new Student("Jesse", "jesse@email.com", "08 555 7777", "101", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.Add(new Student("Andre", "Andre.email.com", "08 555 8888", "102", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.Add(new Student("Noah", "Noah.email.com", "08 555 9999", "103", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
        }

        [Test]
        public void addStudentToHead()
        {

        }

        [Test]
        public void addStudentToTail()
        {

        }

        [Test]
        public void studentIsFound()
        {

        }

        [Test]
        public void removeFromHead()
        {

        }

        [Test]
        public void removeFromTail()
        {

        }

    }
}
