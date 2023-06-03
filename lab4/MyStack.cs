using System.Collections.Generic;
using System;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class MyStack
    {
       
        public MyStack() { }    
        public MyStack(object[] items)
        {
            this.items = items;
        }

        public MyStack(int size)
        {
                if (size <= 0)
                    throw new ArgumentException("Stack size must be greater than zero.");

                items = new object[size];
            
        }

        private const int Size = 5;
        private int position;

        private object[] items = new object[Size];

        public void Push(object obj)
        {
            if (position >= items.Length)
                throw new InvalidOperationException("Stack is full.");
            items[position++] = obj;

        }

        public object Pop()
        {
            if (position == 0)
                throw new InvalidOperationException("Stack is empty.");

            return items[--position];
        }

        public object Peek()
        {
            if (position == 0)
                throw new InvalidOperationException("Stack is empty.");

            return items[position - 1];
        }
    }
}