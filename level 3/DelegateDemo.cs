using System;

namespace FunctionalPrograms
{
    delegate int Operation(int a, int b);

    class DelegateDemo
    {
        static int Add(int x,int y) => x+y;

        static void Main()
        {
            Operation op = Add;
            Console.WriteLine(op(2,3));
        }
    }
}