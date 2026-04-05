using System;

namespace MethodsPrograms
{
    // Demonstrates methods with parameters
    class MethodsWithParametersProgram
    {
        static void Main()
        {
            Console.Write("Enter two integers: ");
            if(int.TryParse(Console.ReadLine(), out int a) &&
               int.TryParse(Console.ReadLine(), out int b))
            {
                int sum = Add(a, b);
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        // Method with parameters
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}