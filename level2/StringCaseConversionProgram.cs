using System;

namespace StringPrograms
{
    class StringCaseConversionProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
        }
    }
}