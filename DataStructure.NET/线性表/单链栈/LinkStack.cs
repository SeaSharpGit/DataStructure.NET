﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class LinkStack<T> : IMyStack<T>
    {
        public Node<T> Top { get; set; } = null;
        public int Num { get; private set; } = 0;

        //时间复杂度O(1)
        public int GetLength() => Num;

        //时间复杂度O(1)
        public void Clear()
        {
            Num = 0;
            Top = null;
        }

        //时间复杂度O(1)
        public bool IsEmpty() => Num == 0;

        //时间复杂度O(1)
        public void Push(T item)
        {
            if (IsEmpty())
            {
                Top = new Node<T>(item);
            }
            else
            {
                Top = new Node<T>(item, Top);
            }
            Num++;
        }

        //时间复杂度O(1)
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            var result = Top.Data;
            Top = Top.Next;
            Num--;
            return result;
        }

        //时间复杂度O(1)
        public T GetTop()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty");
            }
            return Top.Data;
        }
    }
}
