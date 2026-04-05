using System;

namespace MethodsPrograms
{
    class FactorialRecursionProgram
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial = {Factorial(n)}");
        }

        static int Factorial(int n)
        {
            if(n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}