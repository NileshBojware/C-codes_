using System;

namespace OOPBasics
{
    class Base
    {
        public virtual void Show() => Console.WriteLine("Base");
    }

    class Derived : Base
    {
        public override void Show() => Console.WriteLine("Derived");
    }

    class MethodOverridingDemo
    {
        static void Main()
        {
            Base obj = new Derived();
            obj.Show();
        }
    }
}