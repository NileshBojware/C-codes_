using System;

namespace OOPBasics
{
    // Demonstrates Class and Object
    class Student
    {
        public string Name;
        public void Display() => Console.WriteLine($"Student: {Name}");
    }

    class ClassObjectDemo
    {
        static void Main()
        {
            Student s = new Student(); // Object creation
            s.Name = "Nilesh";
            s.Display();
        }
    }
}