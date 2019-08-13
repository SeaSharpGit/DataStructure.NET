using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class HuffmanNode
    {
        public int Weight { get; set; } = 0;
        public int LeftChild { get; set; } = -1;
        public int RightChild { get; set; } = -1;
        public int Parent { get; set; } = -1;

    }
}
