using System;

class ten
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping: a = " + a + ", b = " + b);
    }
}
