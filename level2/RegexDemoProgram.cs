using System;
using System.Text.RegularExpressions;

namespace ValidationPrograms
{
    class RegexDemoProgram
    {
        static void Main()
        {
            string text = "abc123";
            Console.WriteLine(Regex.IsMatch(text, "\d+"));
        }
    }
}