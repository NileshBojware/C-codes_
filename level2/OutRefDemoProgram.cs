using System;

namespace MethodsPrograms
{
    class OutRefDemoProgram
    {
        static void Main()
        {
            int a = 5;
            Increment(ref a);
            Console.WriteLine($"Ref: {a}");

            int result;
            GetValue(out result);
            Console.WriteLine($"Out: {result}");
        }

        static void Increment(ref int x)
        {
            x++;
        }

        static void GetValue(out int value)
        {
            value = 100;
        }
    }
}