using System;

namespace FunctionalPrograms
{
    class LambdaExpressionDemo
    {
        static void Main()
        {
            Func<int,int> square = x => x * x;
            Console.WriteLine(square(5));
        }
    }
}