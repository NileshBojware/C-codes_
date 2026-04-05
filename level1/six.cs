using System;

class six
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Positive number");
        else if (num < 0)
            Console.WriteLine("Negative number");
        else
            Console.WriteLine("Number is Zero");
    }
}
