using System;
class EnumDemo {
    enum Days {Sun,Mon,Tue,Wed,Thu,Fri,Sat}
    static void Main() {
        Days d = Days.Mon;
        Console.WriteLine(d);
    }
}