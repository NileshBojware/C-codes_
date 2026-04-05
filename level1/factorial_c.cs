using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}