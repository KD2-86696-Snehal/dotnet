using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student = null;
            Console.WriteLine("Enter no of Students");
            int n = Convert.ToInt32(Console.ReadLine());
            createArray(n, ref student);
            acceptDetails(student);
            displayDetails(student);


            Student[] reversedStudents = revArray(student);
            Console.WriteLine("Reversed Student Information:");
            displayDetails(reversedStudents);



        }
        public static void createArray(int n, ref Student[] student)
        {
            student = new Student[n];

        }


        public static void acceptDetails(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter RollNo-");
                int _rollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name-");
                string name = Console.ReadLine();

                Console.WriteLine("Enter marks-");
                double marks = Convert.ToDouble(Console.ReadLine());

                student[i] = new Student(_rollNo, name, marks);
            }
        }

        public static void displayDetails(Student[] student)
        {
            //return _rollNo.ToString() + " " + name + " " + marks.ToString();
            foreach (var item in student)
            {
                Console.WriteLine(item.RollNo + " " + item.Name + " " + item.Marks);

            }
        }


        public static Student[] revArray(Student[] student)
        {
            Student[] reversedArray = new Student[student.Length];
            for (int i = 0; i < student.Length; i++)
            {
                reversedArray[i] = student[student.Length - 1 - i];
            }
            return reversedArray;
        }



    }

    public class Student
    {
        private int _rollNo;
        private string name;
        private double marks;

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }


        public Student(int _rollNo, string name, double marks)
        {
            this._rollNo = _rollNo;
            this.name = name;
            this.marks = marks;
        }



    }
}

