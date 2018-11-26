using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(2);

            try
            {
                myStack.Pop();
            }
            catch (MyStackIsEmptyException e)
            {
                Console.WriteLine(e.Message);
            }

            myStack.Push(0);

            Console.WriteLine(myStack.Pop());
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);




        }
    }
}
