using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class LinkNode<T>
    {
        public T Data { get; set; } = default;
        public LinkNode<T> Next { get; set; } = null;

        public LinkNode(T data, LinkNode<T> next)
        {
            Data = data;
            Next = next;
        }
        public LinkNode(LinkNode<T> next)
        {
            Next = next;
        }
        public LinkNode(T data)
        {
            Data = data;
        }
        public LinkNode()
        {

        }
    }
}
