using System;
class SwitchCaseDemo {
    static void Main() {
        Console.Write("Enter day number: ");
        int day = int.Parse(Console.ReadLine());
        switch(day){
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            default: Console.WriteLine("Invalid"); break;
        }
    }
}