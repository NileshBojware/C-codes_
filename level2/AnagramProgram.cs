using System;
using System.Linq;

namespace StringPrograms
{
    class AnagramProgram
    {
        static void Main()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine();

            bool result = s1.OrderBy(c=>c).SequenceEqual(s2.OrderBy(c=>c));
            Console.WriteLine(result ? "Anagram" : "Not Anagram");
        }
    }
}