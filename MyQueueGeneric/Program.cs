using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<Person> personQueue = new MyQueue<Person>();

            personQueue.Enqueue(new Person("1", "Henrik"));
            personQueue.Enqueue(new Person("2", "Poul"));
            personQueue.Enqueue(new Person("3", "Lars"));
            personQueue.Enqueue(new Car(1,"BMW"));

            Console.WriteLine(personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());

           // personQueue.Enqueue(6); cannot convert from 'int' to 'Person' - so can't compile
            
            MyQueue<int> intQueue = new MyQueue<int>();
            intQueue.Enqueue(6);
            intQueue.Enqueue(5);
            Console.WriteLine(intQueue.Dequeue());
            Console.WriteLine(intQueue.Dequeue());
        }
    }
}
