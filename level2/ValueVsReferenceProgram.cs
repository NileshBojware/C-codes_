using System;

namespace AdvancedPrograms
{
    class ValueVsReferenceProgram
    {
        static void Main()
        {
            int a = 5;
            int b = a;
            b = 10;

            Console.WriteLine(a); // value type

            int[] arr1 = {1};
            int[] arr2 = arr1;
            arr2[0] = 5;

            Console.WriteLine(arr1[0]); // reference type
        }
    }
}