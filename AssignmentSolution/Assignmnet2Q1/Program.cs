using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet2Q1
{
    internal class Program
    {
        struct Student
        {

            private string name;
            private bool gender;
            private int age;
            private int std;
            private char div;
            private double marks;

            public char Div
            {
                get { return div; }
                set { div = value; }
            }

            public double Marks
            {
                get { return marks; }
                set { marks = value; }
            }


            public int Std
            {
                get { return std; }
                set { std = value; }
            }




            public int Age
            {
                get { return age; }
                set { age = value; }
            }


            public bool Gender
            {
                get { return gender; }
                set { gender = value; }
            }


            public string Name
            {
                get { return name; }
                set { name = value; }
            }


            //public Student()
            //{
            //    this.name = " ";
            //    this.gender = true;
            //    this.age = 15;
            //    this.std = 7;
            //    this.div = 'a';
            //    this.marks = 50;
            //}
            public Student(string name, bool gender, int age, int std, char div, double marks)
            {
                this.name = name;
                this.gender = gender;
                this.age = age;
                this.std = std;
                this.div = div;
                this.marks = marks;

            }


            public void acceptDetails()
            {
                Console.WriteLine("Enter name,Gender,age,std,div,marks");
                name = Console.ReadLine();
                string gen = Console.ReadLine();
                gender = Convert.ToBoolean(gen);

                string ageValue = Console.ReadLine();
                age = Convert.ToInt32(ageValue);

                string stdValue = Console.ReadLine();
                std = Convert.ToInt32(stdValue);

                string divValue = Console.ReadLine();
                div = Convert.ToChar(divValue);

                string marksValue = Console.ReadLine();
                marks = Convert.ToInt32(marksValue);

            }
            public string PrintDetails()
            {
                return name + " " + Gender.ToString() + " " + age.ToString() + " " + std.ToString() + " " + div.ToString() + " " + marks.ToString();
            }






        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.acceptDetails();

            Console.WriteLine(s.PrintDetails());


        }
    }
}

