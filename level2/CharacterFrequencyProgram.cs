using System;
using System.Collections.Generic;

namespace StringPrograms
{
    class CharacterFrequencyProgram
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            Dictionary<char,int> freq = new Dictionary<char,int>();

            foreach(char c in input)
            {
                if(freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            foreach(var item in freq)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}