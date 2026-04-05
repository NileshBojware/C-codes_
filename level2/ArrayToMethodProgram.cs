using System;

namespace ArrayPrograms
{
    class ArrayToMethodProgram
    {
        static void Main()
        {
            int[] arr = {1,2,3,4};
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach(int n in arr)
                Console.Write(n + " ");
        }
    }
}