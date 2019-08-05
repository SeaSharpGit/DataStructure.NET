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

        public int GetLength()
        {
            return _Size;
        }

        public bool IsEmpty() => _Size == 0;

        public void Clear()
        {
            _Size = 0;
            _Front = null;
            _Rear = null;
        }

        public void In(T item)
        {
            if (IsEmpty())
            {

            }
        }

        public T Out()
        {

        }

        public T GetFront()
        {

        }


    }
}
