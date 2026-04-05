using System;

namespace MethodsPrograms
{
    class RecursionDemoProgram
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Print(n);
        }

        // Recursive method
        static void Print(int n)
        {
            if(n == 0) return;
            Console.WriteLine(n);
            Print(n - 1);
        }
    }
}