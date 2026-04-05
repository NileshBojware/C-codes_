using System;
using System.Linq;

namespace LINQPrograms
{
    class LinqWhereSelectDemo
    {
        static void Main()
        {
            int[] nums = {1,2,3,4,5};
            var result = nums.Where(n => n > 2).Select(n => n * 2);

            foreach(var r in result)
                Console.WriteLine(r);
        }
    }
}