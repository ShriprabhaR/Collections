using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class GenericCollectionQueue
    {
        public static void QueueGenericCollection()
        {
            Queue<double> queue = new Queue<double>();
            queue.Enqueue(29.6);
            queue.Enqueue(65.2);
            queue.Enqueue(13.65);

            foreach(double item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removed element: " + queue.Dequeue());

        }
    }
}
