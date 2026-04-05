using System;

namespace StringPrograms
{
    class StringComparisonProgram
    {
        static void Main()
        {
            string s1 = "hello";
            string s2 = "Hello";

            Console.WriteLine(s1.Equals(s2, StringComparison.OrdinalIgnoreCase)
                ? "Equal" : "Not Equal");
        }
    }
}