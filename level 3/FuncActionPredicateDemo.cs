using System;

namespace FunctionalPrograms
{
    class FuncActionPredicateDemo
    {
        static void Main()
        {
            Func<int,int> square = x => x*x;
            Action<string> print = msg => Console.WriteLine(msg);
            Predicate<int> isEven = x => x%2==0;

            print(square(5).ToString());
            Console.WriteLine(isEven(4));
        }
    }
}