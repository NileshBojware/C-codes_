using System;
class ConditionalDemo {
    static void Main() {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        if(n>0) Console.WriteLine("Positive");
        else if(n<0) Console.WriteLine("Negative");
        else Console.WriteLine("Zero");
    }
}