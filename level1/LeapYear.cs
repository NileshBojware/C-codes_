using System;
class LeapYear {
    static void Main() {
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());
        bool leap = (y%4==0 && y%100!=0) || (y%400==0);
        Console.WriteLine(leap ? "Leap Year" : "Not Leap Year");
    }
}