using System;
struct Student {
    public int id;
    public string name;
}
class StructDemo {
    static void Main() {
        Student s;
        s.id = 1;
        s.name = "John";
        Console.WriteLine(s.id + " " + s.name);
    }
}