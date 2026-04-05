using System;
class RandomNumbers {
    static void Main() {
        Random rand = new Random();
        for(int i=0;i<5;i++){
            Console.WriteLine(rand.Next(1,100));
        }
    }
}