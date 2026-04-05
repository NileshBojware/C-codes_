using System;

namespace OOPBasics
{
    interface IPrinter
    {
        void Print();
    }

    class Printer : IPrinter
    {
        public void Print() => Console.WriteLine("Printing...");
    }

    class InterfaceDemo
    {
        static void Main()
        {
            IPrinter p = new Printer();
            p.Print();
        }
    }
}