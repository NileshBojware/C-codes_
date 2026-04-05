using System;
using System.Linq;

namespace LINQPrograms
{
    class LinqGroupByDemo
    {
        static void Main()
        {
            string[] names = {"Aman","Ankit","Bob"};
            var groups = names.GroupBy(n => n[0]);

            foreach(var g in groups)
            {
                Console.WriteLine(g.Key);
                foreach(var name in g)
                    Console.WriteLine(name);
            }
        }
    }
}