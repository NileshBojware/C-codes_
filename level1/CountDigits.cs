using System;
class CountDigits {
    static void Main() {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int count = 0;
        while(num != 0){
            count++;
            num /= 10;
        }
        Console.WriteLine("Total digits: " + count);
    }
}