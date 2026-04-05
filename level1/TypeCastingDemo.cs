using System;
class TypeCastingDemo {
    static void Main() {
        double d = 10.75;
        int i = (int)d;
        Console.WriteLine("Explicit: " + i);

        int x = 5;
        double y = x;
        Console.WriteLine("Implicit: " + y);
    }
}