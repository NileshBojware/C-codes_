using System;

namespace GenericPrograms
{
    class Demo<T> where T : class
    {
        public void Show(T val) => Console.WriteLine(val);
    }

    class GenericConstraintDemo
    {
        static void Main()
        {
            Demo<string> d = new Demo<string>();
            d.Show("Hello");
        }
    }
}