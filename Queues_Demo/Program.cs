using Queues_Library;

namespace Queues_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> intQueue = new CustomQueue<int>();

            intQueue.QueueData(1);
            intQueue.QueueData(2);
            intQueue.QueueData(3);
            intQueue.QueueData(4);
            intQueue.QueueData(5);

            Console.WriteLine();

            Console.WriteLine($"We have dequeued {intQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {intQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {intQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {intQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {intQueue.DequeueData()}.");

            Console.WriteLine();

            CustomQueue<string> stringQueue = new CustomQueue<string>();

            stringQueue.QueueData("A");
            stringQueue.QueueData("B");
            stringQueue.QueueData("C");
            stringQueue.QueueData("D");
            stringQueue.QueueData("E");

            Console.WriteLine();

            Console.WriteLine($"We have dequeued {stringQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {stringQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {stringQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {stringQueue.DequeueData()}.");
            Console.WriteLine($"We have dequeued {stringQueue.DequeueData()}.");
        }
    }
}