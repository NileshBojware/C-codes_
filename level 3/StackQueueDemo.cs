using System;
using System.Collections.Generic;

namespace CollectionsAdvanced
{
    class StackQueueDemo
    {
        static void Main()
        {
            // Stack (LIFO)
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine($"Stack Pop: {stack.Pop()}");

            // Queue (FIFO)
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            Console.WriteLine($"Queue Dequeue: {queue.Dequeue()}");
        }
    }
}