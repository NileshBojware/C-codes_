using System;

namespace StringPrograms
{
    class ReverseStringProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(new string(arr));
        }
    }
}