using System;
class PalindromeNumber {
    static void Main() {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int original = num, rev = 0;
        while(num != 0){
            rev = rev * 10 + (num % 10);
            num /= 10;
        }
        Console.WriteLine(original == rev ? "Palindrome" : "Not Palindrome");
    }
}