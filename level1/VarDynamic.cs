using System;
class VarDynamic {
    static void Main() {
        var x = 10;
        dynamic y = "Hello";
        Console.WriteLine(x);
        Console.WriteLine(y);
        y = 20;
        Console.WriteLine(y);
    }
}