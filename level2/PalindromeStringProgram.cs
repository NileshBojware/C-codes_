using System;

namespace StringPrograms
{
    class PalindromeStringProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine(input.Equals(reversed) ? "Palindrome" : "Not Palindrome");
        }
    }
}