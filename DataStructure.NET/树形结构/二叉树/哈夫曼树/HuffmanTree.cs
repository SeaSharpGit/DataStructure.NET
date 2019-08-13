using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class HuffmanTree
    {
        private readonly HuffmanNode[] _Items = null;
        private readonly int[] _Weights = null;
        public int LeafNum
        {
            get
            {
                return _Weights.Length;
            }
        }

        public HuffmanTree(int[] weights)
        {
            if (weights.Length <= 0)
            {
                throw new Exception("Error");
            }
            _Weights = weights;
            _Items = new HuffmanNode[2 * weights.Length - 1];
            for (int i = 0; i < 2 * weights.Length - 1; i++)
            {
                _Items[i] = new HuffmanNode();
            }
        }

        public void Create()
        {
            //输入 n 个叶子结点的权值
            for (int i = 0; i < _Weights.Length; ++i)
            {
                _Items[i].Weight = _Weights[i];
            }
            for (int i = 0; i < _Weights.Length - 1; i++)
            {
                var min1 = int.MaxValue;
                var min2 = int.MaxValue;
                var index1 = -1;
                var index2 = -1;
                for (int j = 0; j < _Weights.Length + i; j++)
                {
                    var weight = _Items[j].Weight;
                    if (_Items[j].Parent != -1)
                    {
                        continue;
                    }
                    if (weight < min1)
                    {
                        min2 = min1;
                        index2 = index1;
                        min1 = weight;
                        index1 = j;
                    }
                    else if (weight < min2)
                    {
                        min2 = weight;
                        index2 = j;
                    }
                }
                _Items[_Weights.Length + i].Weight = min1 + min2;
                _Items[_Weights.Length + i].LeftChild = index1;
                _Items[_Weights.Length + i].RightChild = index2;
                _Items[index1].Parent = _Weights.Length + i;
                _Items[index2].Parent = _Weights.Length + i;
            }


        }

    }
}
