    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class MyStack
    {
        private int[] stack;
        private int top = 0;

        public MyStack(int size)
        {
            stack = new int[size];
        }
        public void Push(int element)
        {
            stack[top++] = element;
        }

        public int Pop()
        {
            if(top==0) throw new MyStackIsEmptyException("The stack is empty!");
            return stack[--top];
        }
    }
}
