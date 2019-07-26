using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class Node<T>
    {
        public T Data { get; set; } = default;
        public Node<T> Next { get; set; } = null;

        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
        public Node(Node<T> next)
        {
            Next = next;
        }
        public Node(T data)
        {
            Data = data;
        }
        public Node()
        {

        }
    }
}
