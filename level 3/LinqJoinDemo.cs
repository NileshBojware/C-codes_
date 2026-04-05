using System;
using System.Linq;

namespace LINQPrograms
{
    class LinqJoinDemo
    {
        static void Main()
        {
            var students = new[]{ new {Id=1,Name="A"} };
            var marks = new[]{ new {Id=1,Score=90} };

            var result = students.Join(marks,
                s => s.Id,
                m => m.Id,
                (s,m) => new {s.Name,m.Score});

            foreach(var r in result)
                Console.WriteLine($"{r.Name} {r.Score}");
        }
    }
}