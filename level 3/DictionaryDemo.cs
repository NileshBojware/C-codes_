using System;
using System.Collections.Generic;

namespace CollectionsPrograms
{
    class DictionaryDemo
    {
        static void Main()
        {
            Dictionary<int,string> dict = new Dictionary<int,string>();
            dict.Add(1,"One");

            Console.WriteLine(dict[1]);
        }
    }
}