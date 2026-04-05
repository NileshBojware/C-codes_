using System;
class PowerOfNumber {
    static void Main() {
        Console.Write("Enter base: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter exponent: ");
        int e = int.Parse(Console.ReadLine());
        double result = Math.Pow(b,e);
        Console.WriteLine("Result: " + result);
    }
}