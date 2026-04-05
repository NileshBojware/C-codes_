using System;

namespace StringPrograms
{
    class WordCountProgram
    {
        static void Main()
        {
            Console.Write("Enter sentence: ");
            string input = Console.ReadLine();

            int count = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine($"Word Count: {count}");
        }
    }
}