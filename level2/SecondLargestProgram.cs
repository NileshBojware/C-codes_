using System;

namespace ArrayPrograms
{
    class SecondLargestProgram
    {
        static void Main()
        {
            int[] arr = {10,20,30,40};
            int first = int.MinValue, second = int.MinValue;

            foreach(int n in arr)
            {
                if(n > first)
                {
                    second = first;
                    first = n;
                }
                else if(n > second && n != first)
                {
                    second = n;
                }
            }

            Console.WriteLine($"Second Largest: {second}");
        }
    }
}