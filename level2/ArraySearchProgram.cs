using System;

namespace ArrayPrograms
{
    class ArraySearchProgram
    {
        static void Main()
        {
            int[] arr = {10, 20, 30, 40};
            Console.Write("Enter element to search: ");
            int key = int.Parse(Console.ReadLine());

            int index = Array.IndexOf(arr, key);

            if(index != -1)
                Console.WriteLine($"Element found at index {index}");
            else
                Console.WriteLine("Element not found");
        }
    }
}