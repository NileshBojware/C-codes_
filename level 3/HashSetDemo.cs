using System;
using System.Collections.Generic;

namespace CollectionsAdvanced
{
    class HashSetDemo
    {
        static void Main()
        {
            HashSet<int> set = new HashSet<int>(){1,2,2,3};
            foreach(var item in set)
                Console.WriteLine(item);
        }
    }
}