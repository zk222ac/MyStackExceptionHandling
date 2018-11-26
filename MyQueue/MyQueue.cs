using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueInt
{
    class MyQueue
    {
        private const int DEFAULTSIZE = 10;
        private int[] data;
        private int _top = 0;
        private int _buttom = 0;
        private int _numItems = 0;

        public MyQueue()
        {
            data = new int[DEFAULTSIZE];
        }

        public MyQueue(int size)
        {
            if (size<=0)
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            data = new int[size];
        }

        public void Enqueue(int item)
        {
            if (_numItems==data.Length)
                throw new Exception("The queue is full");
            data[_buttom++] = item;
            _buttom %= data.Length;
            _numItems++;
        }

        public int Dequeue()
        {
            if (_numItems==0)
                throw new Exception("The queue is empty");
            int queueItem = data[_top++];
            _top %= data.Length;
            _numItems--;
            return queueItem;
        }
    }
}
