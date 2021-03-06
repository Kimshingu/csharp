﻿using System;
namespace tutorialspoint
{
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        // Declare a Code property of type string:
        public string Code
        {
            set{ code = value;}
            get{return code;}
            
        }

        // Declare a Name property of type string:
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        // Declare a Age property of type int:
        public int Age
        {
            set { age = value; }
            get { return age; }
        }

        public override string ToString()
        {
            return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
        }
    }
    class ExampleDemo
    {
        public static void Main()
        {

            // Create a new Student object:
            Student s = new Student();

            // Setting code, name and the age of the student
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s);

            //let us increase age
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}



