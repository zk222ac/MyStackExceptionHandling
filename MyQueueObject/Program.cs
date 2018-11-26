using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueObject
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

            MyQueue personQueue = new MyQueue();

            personQueue.Enqueue(new Person("1", "Henrik"));
            personQueue.Enqueue(new Person("2", "Poul"));
      //      personQueue.Enqueue(new Point(3, 5));
            personQueue.Enqueue(new Person("3", "Lars"));

            Console.WriteLine((Person)personQueue.Dequeue());
            Console.WriteLine((Person)personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());

            //Notice: it's not nessasary to type-cast - since ToString is defined in class Object


        }
    }       
    
}
