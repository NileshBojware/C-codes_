using System;

class seven
{
    static void Main()
    {
        Console.Write("Principal: ");
        double p = double.Parse(Console.ReadLine());

        Console.Write("Rate: ");
        double r = double.Parse(Console.ReadLine());

        Console.Write("Time: ");
        double t = double.Parse(Console.ReadLine());

        double si = (p * r * t) / 100;
        Console.WriteLine("Simple Interest = " + si);
    }
}
