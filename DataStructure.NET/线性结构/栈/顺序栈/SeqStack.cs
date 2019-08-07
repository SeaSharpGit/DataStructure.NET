using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class SeqStack<T> : IMyStack<T>
    {
        private readonly T[] _Items;
        public int MaxSize { get; private set; } = 0;
        public int Top { get; private set; } = -1;

        public SeqStack(int size)
        {
            _Items = new T[size];
            MaxSize = size;
        }

        //时间复杂度O(1)
        public int GetLength() => Top + 1;

        //时间复杂度O(1)
        public bool IsEmpty() => Top == -1;

        //时间复杂度O(1)
        public void Clear() => Top = -1;

        //时间复杂度O(1)
        public bool IsFull() => MaxSize == Top + 1;

        //时间复杂度O(1)
        public void Push(T item)
        {
            if (IsFull())
            {
                throw new Exception("Full");
            }
            _Items[++Top] = item;
        }

        //时间复杂度O(1)
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            var result = _Items[Top];
            Top--;
            return result;
        }

        //时间复杂度O(1)
        public T GetTop()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            return _Items[Top];
        }

    }
}
