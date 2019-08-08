using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class DoubleLinkNode<T>
    {
        public T Data { get; set; } = default;
        public DoubleLinkNode<T> Prev { get; set; } = null;
        public DoubleLinkNode<T> Next { get; set; } = null;

        public DoubleLinkNode(T data, DoubleLinkNode<T> prev, DoubleLinkNode<T> next)
        {
            Data = data;
            Prev = prev;
            Next = next;
        }

        public DoubleLinkNode(T data)
        {
            Data = data;
        }

        public DoubleLinkNode()
        {

        }

    }
}
