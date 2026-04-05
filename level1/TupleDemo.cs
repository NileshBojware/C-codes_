using System;
class TupleDemo {
    static void Main() {
        var data = (id:1, name:"Alice");
        Console.WriteLine(data.id + " " + data.name);
    }
}