using System;

namespace ArrayPrograms
{
    class ArrayReadDisplayProgram
    {
        static void Main()
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            // Input elements
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i+1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Display elements
            Console.WriteLine("Array Elements:");
            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}