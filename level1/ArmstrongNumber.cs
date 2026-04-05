using System;
class ArmstrongNumber {
    static void Main() {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int original = num, sum = 0;
        while(num != 0){
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }
        Console.WriteLine(original == sum ? "Armstrong" : "Not Armstrong");
    }
}