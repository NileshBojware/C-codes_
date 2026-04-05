using System;

namespace FunctionalPrograms
{
    class Publisher
    {
        public event Action OnProcess;

        public void Process()
        {
            Console.WriteLine("Processing...");
            OnProcess?.Invoke();
        }
    }

    class EventsDemo
    {
        static void Main()
        {
            Publisher p = new Publisher();
            p.OnProcess += () => Console.WriteLine("Event Triggered");
            p.Process();
        }
    }
}