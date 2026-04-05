using System;
using System.Text.RegularExpressions;

namespace StringPrograms
{
    class RemoveSpecialCharsProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string result = Regex.Replace(input, "[^a-zA-Z0-9]", "");
            Console.WriteLine(result);
        }
    }
}