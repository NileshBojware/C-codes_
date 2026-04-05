using System;

namespace StringPrograms
{
    class StringImmutabilityProgram
    {
        static void Main()
        {
            string s = "Hello";
            s.Replace("H", "Y");
            Console.WriteLine(s); // unchanged
        }
    }
}