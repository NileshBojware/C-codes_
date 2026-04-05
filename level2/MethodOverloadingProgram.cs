using System;

namespace MethodsPrograms
{
    // Demonstrates method overloading
    class MethodOverloadingProgram
    {
        static void Main()
        {
            Console.WriteLine(Add(5, 10));
            Console.WriteLine(Add(5.5, 2.5));
        }

        static int Add(int a, int b) => a + b;
        static double Add(double a, double b) => a + b;
    }
}