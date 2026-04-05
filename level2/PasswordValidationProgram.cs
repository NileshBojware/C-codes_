using System;
using System.Text.RegularExpressions;

namespace ValidationPrograms
{
    class PasswordValidationProgram
    {
        static void Main()
        {
            Console.Write("Enter password: ");
            string pass = Console.ReadLine();

            bool valid = Regex.IsMatch(pass, @"^(?=.*[A-Z])(?=.*\d).{6,}$");
            Console.WriteLine(valid ? "Strong" : "Weak");
        }
    }
}