using System;
using System.IO;

namespace IOPrograms
{
    class FileHandlingDemo
    {
        static void Main()
        {
            File.WriteAllText("demo.txt","Hello");
            string data = File.ReadAllText("demo.txt");
            Console.WriteLine(data);
        }
    }
}