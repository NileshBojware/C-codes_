using System;
using System.Linq;

namespace ArrayPrograms
{
    class CommonElementsProgram
    {
        static void Main()
        {
            int[] a = {1,2,3};
            int[] b = {2,3,4};

            var common = a.Intersect(b);
            foreach(var c in common)
                Console.WriteLine(c);
        }
    }
}