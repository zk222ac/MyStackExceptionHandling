using System;
using System.Collections.Generic;

namespace MyQueueGeneric
{
    class MyQueue<T>
    {
        private const int DEFAULTSIZE = 10;
        private T[] data;
        private int _top = 0;
        private int _buttom = 0;
        private int _numItems = 0;

        public MyQueue()
        {
            data = new T[DEFAULTSIZE];
        }

        public MyQueue(int size)
        {
            if (size<=0)
                throw new ArgumentOutOfRangeException("size", "Must be greater than zero");
            data = new T[size];
        }

        public void Enqueue(T item)
        {
            if (_numItems==data.Length)
                throw new Exception("The queue is full");
            data[_buttom++] = item;
            _buttom %= data.Length;
            _numItems++;
        }

        public T Dequeue()
        {
            if (_numItems==0)
                throw new Exception("The queue is empty");
            T queueItem = data[_top++];
            _top %= data.Length;
            _numItems--;
            return queueItem;
        }
    }
}
