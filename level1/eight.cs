using System;

class eight
{
    static void Main()
    {
        Console.Write("Principal: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Rate: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Time (years): ");
        double t = double.Parse(Console.ReadLine());

        double amount = p * Math.Pow((1 + r / 100), t);
        double ci = amount - p;

        Console.WriteLine("Compound Interest = " + ci);
    }
}
