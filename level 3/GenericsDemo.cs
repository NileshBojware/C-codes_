using System;

namespace GenericPrograms
{
    class GenericClass<T>
    {
        public T Value;
    }

    class GenericsDemo
    {
        static void Main()
        {
            GenericClass<int> obj = new GenericClass<int>();
            obj.Value = 10;
            Console.WriteLine(obj.Value);
        }
    }
}