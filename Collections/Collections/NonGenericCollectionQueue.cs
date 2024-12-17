using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class NonGenericCollectionQueue
    {
        public static void QueueNonGenericCollection()
        {
            Queue queue = new Queue();
            queue.Enqueue("Garuda mall");
            queue.Enqueue(120000);
            queue.Enqueue(345.92);
            queue.Enqueue("Innovation");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Removed element: "+queue.Dequeue());
            

        }
    }
}
