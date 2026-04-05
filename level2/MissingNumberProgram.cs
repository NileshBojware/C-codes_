using System;
using System.Linq;

namespace ArrayPrograms
{
    class MissingNumberProgram
    {
        static void Main()
        {
            int[] arr = {1,2,4,5};
            int n = 5;

            int expected = n*(n+1)/2;
            int actual = arr.Sum();

            Console.WriteLine($"Missing: {expected - actual}");
        }
    }
}