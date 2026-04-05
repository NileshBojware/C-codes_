using System;

namespace OOPBasics
{
    // Demonstrates Destructor
    class Demo
    {
        ~Demo()
        {
            Console.WriteLine("Destructor called");
        }
    }

    class DestructorDemo
    {
        static void Main()
        {
            Demo d = new Demo();
        }
    }
}