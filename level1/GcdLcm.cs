using System;
class GcdLcm {
    static void Main() {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int gcd = GCD(a,b);
        int lcm = (a*b)/gcd;

        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }

    static int GCD(int a,int b){
        while(b!=0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}