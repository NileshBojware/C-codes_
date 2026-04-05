using System;

namespace AdvancedPrograms
{
    class ReflectionDemo
    {
        static void Main()
        {
            Type t = typeof(string);
            Console.WriteLine(t.Name);
        }
    }
}