using System;

namespace StringPrograms
{
    class ReplaceSubstringProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();

            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();

            string result = input.Replace(oldWord, newWord);

            Console.WriteLine(result);
        }
    }
}