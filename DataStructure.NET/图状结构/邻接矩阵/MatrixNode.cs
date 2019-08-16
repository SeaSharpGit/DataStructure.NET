using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class MatrixNode<T>
    {
        public MatrixNode(T item)
        {
            Data = item;
        }

        public MatrixNode()
        {

        }

        public T Data { get; set; } = default;
    }
}
