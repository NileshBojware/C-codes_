using System;
class DateTimeDemo {
    static void Main() {
        DateTime now = DateTime.Now;
        Console.WriteLine("Current Date: " + now.ToShortDateString());
        Console.WriteLine("Current Time: " + now.ToLongTimeString());
    }
}