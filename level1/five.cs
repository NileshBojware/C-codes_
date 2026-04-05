using System;

class five
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("Even number");
        else
            Console.WriteLine("Odd number");
    }
}
