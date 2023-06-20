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
    public class LinkedList_Testing
    {
        public PRG547_Assignment01_SimonJohnson.LinkedList<Student> studentList;
        public Student student1;
        public Student student2;
        public Utility tools;

        [OneTimeSetUp]
        public void Init()
        {
            // Construct new Student
            Student student1 = new Student("Simon", "simon@email.com", "08 555 6667", "100", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            Student student2 = new Student("jamie", "jamie@email.com", "08 555 8888", "104", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");

            // Construct new Student List
            studentList = new PRG547_Assignment01_SimonJohnson.LinkedList<Student>();
            studentList.Add(new Student("Jesse", "jesse@email.com", "08 555 7777", "101", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.Add(new Student("Andre", "Andre.email.com", "08 555 8888", "102", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));
            studentList.Add(new Student("Noah", "Noah.email.com", "08 555 9999", "103", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01"));

            tools = new Utility();
        }

        [Test]
        public void addStudentToHead()
        {
            studentList.AddFirst(student1);
            Assert.AreEqual(student1, studentList.Head.Value);
        }

        [Test]
        public void addStudentToTail()
        {
            studentList.AddLast(student2);
            Assert.AreEqual(student2, studentList.Tail.Value);
        }

        [Test]
        public void studentIsFound()
        {
            Assert.AreEqual(student2, tools.SingleSequentialSearch<Student>(studentList, student2));
        }

        [Test]
        public void removeFromHead()
        {
            studentList.RemoveFirst();
            Assert.AreNotEqual(student1, studentList.Head.Value);
        }

        [Test]
        public void removeFromTail()
        {
            studentList.RemoveLast();
            Assert.AreNotEqual(student2, studentList.Tail.Value);
        }

    }
}
