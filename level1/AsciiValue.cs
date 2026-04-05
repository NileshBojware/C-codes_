using System;
class AsciiValue {
    static void Main() {
        Console.Write("Enter character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("\nASCII value: " + (int)ch);
    }
}