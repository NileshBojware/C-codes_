using System;

namespace MethodsPrograms
{
    class StaticMethodsProgram
    {
        static void Main()
        {
            Console.WriteLine(MathUtil.Square(5));
        }
    }

    static class MathUtil
    {
        public static int Square(int x) => x * x;
    }
}