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

    class SearchingAndSorting_Testing
    {
        public List<StudentPart8> studentList;
        public Utility tools;
        public StudentPart8 student1;
        public StudentPart8 student2;
        public StudentPart8 student3;
        public StudentPart8 student4;
        public StudentPart8 student5;
        public StudentPart8 student6;
        public StudentPart8 student7;
        public StudentPart8 student8;
        public StudentPart8 student9;
        public StudentPart8 student10;

        [OneTimeSetUp]
        public void Init()
        {
            studentList = new List<StudentPart8>();
            student1 = new StudentPart8("Simon", "simon@email.com", "08 555 6667", "100", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student2 = new StudentPart8("Jesse", "jesse@email.com", "08 555 7777", "101", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student3 = new StudentPart8("Andre", "Andre.email.com", "08 555 8888", "102", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student4 = new StudentPart8("Noah", "Noah.email.com", "08 555 9999", "103", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student5 = new StudentPart8("Prince", "prince@email.com", "08 555 8888", "104", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student6 = new StudentPart8("Chan", "chan@email.com", "08 555 8889", "105", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student7 = new StudentPart8("Khurl", "khurl@email.com", "08 555 8880", "106", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student8 = new StudentPart8("Andrew", "andrew@email.com", "08 555 8881", "107", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student9 = new StudentPart8("Matthew", "matthew@email.com", "08 555 8882", "108", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            student10 = new StudentPart8("Adam", "adam@email.com", "08 555 8883", "109", "Currie Street", "Adelaide", "5000", "SA", "PRG547", new DateTime(2022, 05, 22), new DateTime(2022, 06, 01), "PASS", "Semester 01");
            tools = new Utility();

            studentList.Add(student1);
            studentList.Add(student2);
            studentList.Add(student3);
            studentList.Add(student4);
            studentList.Add(student5);
            studentList.Add(student6);
            studentList.Add(student7);
            studentList.Add(student8);
            studentList.Add(student9);
            studentList.Add(student10);
        }

        [Test]
        public void StudentPart8LinearSearch()
        {
            StudentPart8 target = student3;
            StudentPart8 result = tools.LinearSearchArray<StudentPart8>(studentList, target);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void StudentPart8BinarySearch()
        {
            studentList.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));
            StudentPart8 target = student7;
            StudentPart8 result = tools.LinearSearchArray<StudentPart8>(studentList, target);
            Assert.AreEqual(target, result);
        }

        [Test]
        public void StudentPart8BubbleSort()
        {

        }
    }
}
