using System;

namespace MethodsPrograms
{
    class OptionalParametersProgram
    {
        static void Main()
        {
            Greet("Nilesh");
            Greet("Nilesh", "Good Evening");
        }

        static void Greet(string name, string msg = "Hello")
        {
            Console.WriteLine($"{msg}, {name}");
        }
    }
}