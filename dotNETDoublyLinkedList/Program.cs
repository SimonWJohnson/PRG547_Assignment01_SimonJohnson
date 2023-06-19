﻿using PRG547_Assignment01_SimonJohnson;
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
            //Testing the DoublyLinkedList
            DoublyLinkedList<Student> studentList = new DoublyLinkedList<Student>();
            studentList.Add(new Student("Simon", "simon@email.com", "08 555 6667", "PRG547", DateTime.Now));
            studentList.AddLast(new Student("Jesse", "jesse@email.com", "08 555 7777", "PRG547", DateTime.Now));
            studentList.AddLast(new Student("Andre", "Andre.email.com", "08 555 8888", "PRG547", DateTime.Now));
            studentList.AddLast(new Student("Noah", "Noah.email.com", "08 555 9999", "PRG547", DateTime.Now));

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

            foreach (Student student in studentList)
            {
                string studentInfo = student.ToString();
                Console.WriteLine(studentInfo);
            }
            Console.ReadLine();


            // Testing the LinkedList
            PRG547_Assignment01_SimonJohnson.LinkedList<Student> studentList2 = new PRG547_Assignment01_SimonJohnson.LinkedList<Student>();
            studentList2.Add(new Student("Simon", "simon@email.com", "08 555 6667", "PRG547", DateTime.Now));
            studentList2.AddLast(new Student("Jesse", "jesse@email.com", "08 555 7777", "PRG547", DateTime.Now));
            studentList2.AddLast(new Student("Andre", "Andre.email.com", "08 555 8888", "PRG547", DateTime.Now));
            studentList2.AddLast(new Student("Noah", "Noah.email.com", "08 555 9999", "PRG547", DateTime.Now));
            
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

        }

        static void DisplayWhetherEqual(Student student1, Student student2)
        {
            if (student1 == student2)
            {
                Console.WriteLine(string.Format("{0,12} == {1}", student1, student2));
            }

            else
            {
                Console.WriteLine(string.Format("{0,12} != {1}", student1, student2));
            }
            Console.ReadLine();
        }
    }
}
