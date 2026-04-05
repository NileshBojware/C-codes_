using System;
using System.Collections.Generic;

namespace CollectionsPrograms
{
    class CollectionsListDemo
    {
        static void Main()
        {
            List<int> list = new List<int> {1,2,3};
            list.Add(4);

            foreach(var item in list)
                Console.WriteLine(item);
        }
    }
}