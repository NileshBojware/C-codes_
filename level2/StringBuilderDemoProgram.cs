using System;
using System.Text;

namespace StringPrograms
{
    class StringBuilderDemoProgram
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" World");

            Console.WriteLine(sb.ToString());
        }
    }
}