using System;
class NullableTypes {
    static void Main() {
        int? num = null;
        Console.WriteLine(num.HasValue ? num.Value.ToString() : "Null value");
    }
}