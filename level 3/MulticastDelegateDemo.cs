using System;

namespace FunctionalPrograms
{
    delegate void Notify();

    class MulticastDelegateDemo
    {
        static void A() => Console.WriteLine("A");
        static void B() => Console.WriteLine("B");

        static void Main()
        {
            Notify n = A;
            n += B;
            n();
        }
    }
}