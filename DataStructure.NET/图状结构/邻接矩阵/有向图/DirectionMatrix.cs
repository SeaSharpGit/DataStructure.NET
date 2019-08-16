using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class DirectionMatrix<T> : IDirectionGraph<T>
    {
        private readonly MatrixNode<T>[] _Nodes = null;
        private readonly int[,] _Relations = null;
        private int _EdgeNum = 0;
        private readonly int _Max = int.MaxValue;

        public DirectionMatrix(int length)
        {
            if (length <= 0)
            {
                throw new Exception("Error");
            }
            _Nodes = new MatrixNode<T>[length];
            _Relations = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    _Relations[i, j] = _Max;
                }
            }
        }

        public int GetNodeNum() => _Nodes.Length;

        public int GetEdgeNum() => _EdgeNum;

        public MatrixNode<T> GetNode(int index)
        {
            if (index < 0 || index > GetNodeNum() - 1)
            {
                throw new Exception("Error");
            }
            return _Nodes[index];
        }

        public void SetNode(int index, MatrixNode<T> item)
        {
            if (index < 0 || index > GetNodeNum() - 1)
            {
                throw new Exception("Error");
            }
            _Nodes[index] = item;
        }

        public int GetRelation(int index, int index2)
        {
            if (index < 0 || index > GetNodeNum() - 1 || index2 < 0 || index2 > GetNodeNum() - 1)
            {
                throw new Exception("Error");
            }
            return _Relations[index, index2];
        }

        public int GetIndex(MatrixNode<T> item)
        {
            for (int i = 0; i < GetNodeNum(); i++)
            {
                if (item.Equals(GetNode(i)))
                {
                    return i;
                }
            }
            return -1;
        }

        public void SetEdge(MatrixNode<T> item, MatrixNode<T> item2, int v)
        {
            var index = GetIndex(item);
            var index2 = GetIndex(item2);
            if (index == -1 || index2 == -1)
            {
                throw new Exception("Error");
            }
            if (_Relations[index, index2] == _Max)
            {
                _EdgeNum++;
            }
            _Relations[index, index2] = v;
        }

        public void DeleteEdge(MatrixNode<T> item, MatrixNode<T> item2)
        {
            var index = GetIndex(item);
            var index2 = GetIndex(item2);
            if (index == -1 || index2 == -1)
            {
                throw new Exception("Error");
            }
            if (_Relations[index, index2] != _Max)
            {
                _EdgeNum--;
            }
            _Relations[index, index2] = _Max;
        }

        public bool IsEdge(MatrixNode<T> item, MatrixNode<T> item2)
        {
            var index = GetIndex(item);
            var index2 = GetIndex(item2);
            if (index == -1 || index2 == -1)
            {
                throw new Exception("Error");
            }
            return _Relations[index, index2] != _Max;
        }

        public int GetEdge(MatrixNode<T> item, MatrixNode<T> item2)
        {
            var index = GetIndex(item);
            var index2 = GetIndex(item2);
            if (index == -1 || index2 == -1)
            {
                throw new Exception("Error");
            }
            return _Relations[index, index2];
        }

    }
}
