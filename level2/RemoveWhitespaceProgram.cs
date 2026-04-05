using System;

namespace StringPrograms
{
    class RemoveWhitespaceProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string result = input.Replace(" ", "");

            Console.WriteLine(result);
        }
    }
}