using System;
using System.Linq;

namespace ArrayPrograms
{
    class DuplicateElementsProgram
    {
        static void Main()
        {
            int[] arr = {1,2,2,3,3};
            var dup = arr.GroupBy(x=>x).Where(g=>g.Count()>1).Select(g=>g.Key);

            foreach(var d in dup)
                Console.WriteLine(d);
        }
    }
}