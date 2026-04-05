using System;

namespace OOPBasics
{
    // Demonstrates Constructor
    class Person
    {
        public string Name;

        // Constructor
        public Person(string name)
        {
            Name = name;
        }

        public void Show() => Console.WriteLine(Name);
    }

    class ConstructorDemo
    {
        static void Main()
        {
            Person p = new Person("Nilesh");
            p.Show();
        }
    }
}