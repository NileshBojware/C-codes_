using System;
using System.Threading.Tasks;

namespace AsyncPrograms
{
    class AsyncAwaitDemo
    {
        static async Task Main()
        {
            await Task.Delay(1000);
            Console.WriteLine("Async Completed");
        }
    }
}