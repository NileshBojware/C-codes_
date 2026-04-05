using System;

namespace OOPBasics
{
    interface IA { void A(); }
    interface IB { void B(); }

    class Demo : IA, IB
    {
        public void A() => Console.WriteLine("A method");
        public void B() => Console.WriteLine("B method");
    }

    class MultipleInheritanceInterfaceDemo
    {
        static void Main()
        {
            Demo d = new Demo();
            d.A(); d.B();
        }
    }
}