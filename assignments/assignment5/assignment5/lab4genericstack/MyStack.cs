using System;
using System.Collections.Generic;
using System.Text;

namespace assignment5.lab4genericstack
{
    public class MyStack<T>
    {
        private const int DefaultCapacity = 5;
        private T[] items;
        private int position;

        public MyStack()
        {
            items = new T[DefaultCapacity];
        }

        public MyStack(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Stack size must be greater than zero.");

            items = new T[size];
        }

        public void Push(T obj)
        {
            if (position >= items.Length)
                ResizeArray();

            items[position++] = obj;
        }

        public T Pop()
        {
            if (position == 0)
                throw new InvalidOperationException("Stack is empty.");

            return items[--position];
        }

        public T Peek()
        {
            if (position == 0)
                throw new InvalidOperationException("Stack is empty.");

            return items[position - 1];
        }

        private void ResizeArray()
        {
            int newCapacity = items.Length * 2;
            Array.Resize(ref items, newCapacity);
        }
    }
}
