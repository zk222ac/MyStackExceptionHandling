using System;

namespace MyQueueInt
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue(3);
            
            try
            {
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine(queue.Dequeue());
                Console.WriteLine(queue.Dequeue());
                Console.WriteLine(queue.Dequeue());
                Console.WriteLine(queue.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
