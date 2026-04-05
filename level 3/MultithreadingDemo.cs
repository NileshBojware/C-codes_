using System;
using System.Threading;

namespace AsyncPrograms
{
    class MultithreadingDemo
    {
        static void Work() => Console.WriteLine("Thread Running");

        static void Main()
        {
            Thread t = new Thread(Work);
            t.Start();
        }
    }
}