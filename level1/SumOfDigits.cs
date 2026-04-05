using System;
class SumOfDigits {
    static void Main() {
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        while(num > 0){
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Sum of digits: " + sum);
    }
}