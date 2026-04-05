using System;
class AreaRectangle {
    static void Main() {
        Console.Write("Enter length: ");
        double l = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double w = double.Parse(Console.ReadLine());
        Console.WriteLine("Area: " + (l*w));
    }
}