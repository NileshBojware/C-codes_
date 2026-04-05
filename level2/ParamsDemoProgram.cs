using System;

namespace MethodsPrograms
{
    class ParamsDemoProgram
    {
        static void Main()
        {
            Console.WriteLine(Sum(1,2,3,4));
        }

        static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int n in numbers) sum += n;
            return sum;
        }
    }
}