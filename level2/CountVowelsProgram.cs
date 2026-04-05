using System;

namespace StringPrograms
{
    class CountVowelsProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine().ToLower();

            int count = 0;
            foreach(char c in input)
            {
                if("aeiou".Contains(c))
                    count++;
            }

            Console.WriteLine($"Vowel Count: {count}");
        }
    }
}