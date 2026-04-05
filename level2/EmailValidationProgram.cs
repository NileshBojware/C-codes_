using System;
using System.Text.RegularExpressions;

namespace ValidationPrograms
{
    class EmailValidationProgram
    {
        static void Main()
        {
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            bool valid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            Console.WriteLine(valid ? "Valid" : "Invalid");
        }
    }
}