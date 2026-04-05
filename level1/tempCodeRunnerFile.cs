using System;

class Program
{
    static void Main()
    {
        // Sum of Digits
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine("Sum = " + sum);
    }
}
