using System;
using System.Collections.Generic;
using System.Text;

namespace assignment7
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
        }

        public LinkedListNode<T> Next { get; set; }
    }
}
