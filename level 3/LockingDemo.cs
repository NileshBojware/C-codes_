using System;

namespace AsyncPrograms
{
    class LockingDemo
    {
        static object obj = new object();

        static void Main()
        {
            lock(obj)
            {
                Console.WriteLine("Critical Section");
            }
        }
    }
}