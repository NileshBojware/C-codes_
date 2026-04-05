using System;

namespace AdvancedPrograms
{
    class MemoryManagementProgram
    {
        static void Main()
        {
            Console.WriteLine("Garbage Collector Demo");
            GC.Collect();
            Console.WriteLine("Memory cleaned");
        }
    }
}