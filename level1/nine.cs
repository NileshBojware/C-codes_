using System;

class nine
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int largest = a;

        if (b > largest) largest = b;
        if (c > largest) largest = c;

        Console.WriteLine("Largest number = " + largest);
    }
}
