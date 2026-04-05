using System;
using System.Diagnostics;

namespace AdvancedPrograms
{
    class PerformanceDemo
    {
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            for(int i=0;i<100000;i++){}
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}