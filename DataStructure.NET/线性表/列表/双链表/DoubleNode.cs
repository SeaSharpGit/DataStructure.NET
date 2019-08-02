using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class DoubleNode<T>
    {
        public T Data { get; set; } = default;
        public DoubleNode<T> Prev { get; set; } = null;
        public DoubleNode<T> Next { get; set; } = null;

        public DoubleNode(T data, DoubleNode<T> prev, DoubleNode<T> next)
        {
            Data = data;
            Prev = prev;
            Next = next;
        }

        public DoubleNode(T data)
        {
            Data = data;
        }

        public DoubleNode()
        {

        }

    }
}
