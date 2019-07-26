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
        public Node<T> Prev { get; set; } = null;
        public Node<T> Next { get; set; } = null;

        public DoubleNode(T data)
        {
            Data = data;
        }

        public DoubleNode()
        {

        }

    }
}
