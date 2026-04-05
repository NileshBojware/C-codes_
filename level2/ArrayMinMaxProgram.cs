using System;

namespace ArrayPrograms
{
    class ArrayMinMaxProgram
    {
        static void Main()
        {
            int[] arr = {5, 2, 9, 1, 7};

            int min = arr[0];
            int max = arr[0];

            foreach(int num in arr)
            {
                if(num < min) min = num;
                if(num > max) max = num;
            }

            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Maximum: {max}");
        }
    }
}