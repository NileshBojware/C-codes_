using System;

namespace FunctionalPrograms
{
    static class Extension
    {
        public static int Square(this int x) => x*x;
    }

    class ExtensionMethodDemo
    {
        static void Main()
        {
            int n = 5;
            Console.WriteLine(n.Square());
        }
    }
}