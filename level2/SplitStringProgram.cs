using System;

namespace StringPrograms
{
    class SplitStringProgram
    {
        static void Main()
        {
            Console.Write("Enter sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            foreach(string w in words)
                Console.WriteLine(w);
        }
    }
}