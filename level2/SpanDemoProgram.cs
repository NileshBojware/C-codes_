using System;

namespace AdvancedPrograms
{
    class SpanDemoProgram
    {
        static void Main()
        {
            int[] arr = {1,2,3,4};
            Span<int> span = arr;
            span[0] = 100;
            Console.WriteLine(arr[0]);
        }
    }
}