using System;
using System.Threading.Tasks;

namespace AsyncPrograms
{
    class TPLDemo
    {
        static void Main()
        {
            Task.Run(()=> Console.WriteLine("Task running")).Wait();
        }
    }
}