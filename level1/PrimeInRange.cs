using System;
class PrimeInRange {
    static void Main() {
        Console.Write("Enter start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end: ");
        int end = int.Parse(Console.ReadLine());

        for(int i=start;i<=end;i++){
            if(IsPrime(i))
                Console.Write(i + " ");
        }
    }

    static bool IsPrime(int n){
        if(n<2) return false;
        for(int i=2;i<=Math.Sqrt(n);i++){
            if(n%i==0) return false;
        }
        return true;
    }
}