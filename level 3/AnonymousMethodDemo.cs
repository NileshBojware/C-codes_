using System;

namespace FunctionalPrograms
{
    class AnonymousMethodDemo
    {
        delegate void Show();

        static void Main()
        {
            Show s = delegate { Console.WriteLine("Anonymous"); };
            s();
        }
    }
}