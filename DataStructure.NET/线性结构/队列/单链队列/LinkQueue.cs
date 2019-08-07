using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class LinkQueue<T> : IMyQueue<T>
    {
        private Node<T> _Front = null;
        private Node<T> _Rear = null;
        private int _Size = 0;

        //时间复杂度O(1)
        public int GetLength()
        {
            return _Size;
        }

        //时间复杂度O(1)
        public bool IsEmpty() => _Size == 0;

        //时间复杂度O(1)
        public void Clear()
        {
            _Size = 0;
            _Front = null;
            _Rear = null;
        }

        //时间复杂度O(1)
        public void In(T item)
        {
            _Size++;
            var newNode = new Node<T>(item);
            if (IsEmpty())
            {
                _Front = newNode;
                _Rear = newNode;

                return;
            }
            _Rear.Next = newNode;
            _Rear = newNode;
        }

        //时间复杂度O(1)
        public T Out()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            var result = _Front.Data;
            _Front = _Front.Next;
            if (_Front == null)
            {
                _Rear = null;
            }
            _Size--;
            return result;
        }

        //时间复杂度O(1)
        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            return _Front.Data;
        }
    }
}
