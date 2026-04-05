using System;
class ConstantsReadonly {
    const double PI = 3.14;
    readonly int value;

    public ConstantsReadonly(){
        value = 10;
    }

    static void Main() {
        ConstantsReadonly obj = new ConstantsReadonly();
        Console.WriteLine("Const PI: " + PI);
        Console.WriteLine("Readonly value: " + obj.value);
    }
}