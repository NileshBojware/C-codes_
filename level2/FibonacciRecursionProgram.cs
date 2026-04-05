using System;

namespace MethodsPrograms
{
    class FibonacciRecursionProgram
    {
        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
                Console.Write(Fib(i) + " ");
        }

        static int Fib(int n)
        {
            if(n <= 1) return n;
            return Fib(n-1) + Fib(n-2);
        }
    }
}