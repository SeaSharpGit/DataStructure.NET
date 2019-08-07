using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class SeqQueue<T> : IMyQueue<T>
    {
        private readonly T[] _Items;
        public int MaxSize { get; private set; } = 0;
        public int Front { get; private set; } = -1;
        public int Rear { get; private set; } = -1;

        public SeqQueue(int size)
        {
            _Items = new T[size];
            MaxSize = size;
        }

        //时间复杂度O(1)
        public int GetLength() => (Rear - Front + MaxSize) % MaxSize;

        //时间复杂度O(1)
        public bool IsEmpty() => Front == Rear;

        //时间复杂度O(1)
        public void Clear()
        {
            Front = -1;
            Rear = -1;
        }

        //时间复杂度O(1)
        public bool IsFull() => (Rear - Front + MaxSize) % MaxSize == 0;

        //时间复杂度O(1)
        public void In(T item)
        {
            if (IsFull())
            {
                throw new Exception("Full");
            }
            Rear = (Rear + 1) % MaxSize;
            _Items[Rear] = item;
        }

        //时间复杂度O(1)
        public T Out()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            Front = (Front + 1) % MaxSize;
            return _Items[Front];
        }

        //时间复杂度O(1)
        public T GetFront()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            return _Items[Front + 1];
        }

    }
}
