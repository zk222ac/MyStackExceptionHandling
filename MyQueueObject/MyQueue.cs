using System;

namespace MyQueueObject
{
    class MyQueue
    {
        private const int DEFAULTSIZE = 10;
        private Object[] data;
        private int _top = 0;
        private int _buttom = 0;
        private int _numItems = 0;

        public MyQueue()
        {
            data = new Object[DEFAULTSIZE];
        }

        public MyQueue(int size)
        {
            if (size<=0)
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            data = new Object[size];
        }

        public void Enqueue(Object item)
        {
            if (_numItems==data.Length)
                throw new Exception("The queue is full");
            data[_buttom++] = item;
            _buttom %= data.Length;
            _numItems++;
        }

        public Object Dequeue()
        {
            if (_numItems==0)
                throw new Exception("The queue is empty");
            Object queueItem = data[_top++];
            _top %= data.Length;
            _numItems--;
            return queueItem;
        }
    }
}
