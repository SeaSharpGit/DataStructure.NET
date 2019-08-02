using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    /// <summary>
    /// 线性表中的顺序表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SeqList<T> : IMyList<T>
    {
        private readonly T[] _Items;
        public int MaxSize { get; private set; } = 0;
        public int Last { get; private set; } = -1;

        public SeqList(int size)
        {
            _Items = new T[size];
            MaxSize = size;
        }

        //时间复杂度O(1)
        public int GetLength() => Last + 1;

        //时间复杂度O(1)
        public void Clear() => Last = -1;

        //时间复杂度O(1)
        public bool IsEmpty() => Last == -1;

        //时间复杂度O(1)
        public bool IsFull() => Last == MaxSize - 1;

        //时间复杂度O(1)
        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Full");
                return;
            }

            _Items[++Last] = item;
        }

        //时间复杂度O(n)
        //第i个位置，从1开始
        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                throw new Exception("Full");
            }
            if (i < 1 || i > Last + 2)
            {
                throw new Exception("Index is error");
            }

            for (int j = Last; j >= i - 1; j--)
            {
                _Items[j + 1] = _Items[j];
            }
            _Items[i - 1] = item;
            Last++;
        }

        //时间复杂度O(n)
        //第i个位置，从1开始
        public T Delete(int i)
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            if (i < 1 || i > Last + 1)
            {
                throw new Exception("Position is error");
            }

            var result = _Items[i - 1];
            for (int j = i; j <= Last; j++)
            {
                _Items[j] = _Items[j + 1];
            }
            Last--;
            return result;
        }

        //第i个位置，从1开始
        //时间复杂度O(1)
        public T GetElement(int i)
        {
            if (IsEmpty() || i < 1 || i > Last + 1)
            {
                throw new Exception("Error");
            }
            return _Items[i - 1];
        }

        //时间复杂度O(n)
        //返回值从0开始
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                return -1;
            }
            for (int i = 0; i <= Last; i++)
            {
                if (_Items[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        //时间复杂度O(n)
        public void Reverse()
        {
            var length = GetLength();
            for (int i = 0; i < length / 2; i++)
            {
                var temp = _Items[i];
                _Items[i] = _Items[length - i - 1];
                _Items[length - i - 1] = temp;
            }
        }
    }
}
