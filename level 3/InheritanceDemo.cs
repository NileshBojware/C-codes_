using System;

namespace OOPBasics
{
    // Base class
    class Animal
    {
        public void Speak() => Console.WriteLine("Animal speaks");
    }

    // Derived class
    class Dog : Animal
    {
        public void Bark() => Console.WriteLine("Dog barks");
    }

    class InheritanceDemo
    {
        static void Main()
        {
            Dog d = new Dog();
            d.Speak();
            d.Bark();
        }
    }
}