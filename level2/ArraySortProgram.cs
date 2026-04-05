using System;

namespace ArrayPrograms
{
    class ArraySortProgram
    {
        static void Main()
        {
            int[] arr = {5, 3, 8, 1, 2};

            Array.Sort(arr); // Built-in sorting

            Console.WriteLine("Sorted Array:");
            foreach(int num in arr)
                Console.Write(num + " ");
        }
    }
}