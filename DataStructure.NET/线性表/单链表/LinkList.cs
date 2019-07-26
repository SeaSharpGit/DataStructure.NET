using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    /// <summary>
    /// 线性表中的单链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkList<T> : IMyList<T>
    {
        public Node<T> Head { get; set; } = new Node<T>(default, null);


        //时间复杂度O(n)
        public int GetLength()
        {
            var node = Head.Next;
            var length = 0;
            while (node != null)
            {
                node = node.Next;
                length++;
            }
            return length;
        }

        //时间复杂度O(1)
        public void Clear() => Head.Next = null;

        //时间复杂度O(1)
        public bool IsEmpty() => Head.Next == null;

        //时间复杂度O(n)
        public void Append(T item)
        {
            var newNode = new Node<T>(item);
            if (IsEmpty())
            {
                Head.Next = newNode;
                return;
            }

            var node = Head.Next;
            while (node != null)
            {
                node = node.Next;
            }
            node.Next = newNode;
        }

        //时间复杂度O(n)
        //第i个位置，从1开始
        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                throw new Exception("Error");
            }

            var newNode = new Node<T>(item);
            var l = Head;
            var r = Head.Next;
            var index = 1;
            while (r != null && index < i)
            {
                l = r;
                r = r.Next;
            }
            if (index == i)
            {
                l.Next = newNode;
                newNode.Next = r;
            }
            else
            {
                throw new Exception("Error");
            }
        }

        //时间复杂度O(n)
        //第i个位置，从1开始
        public T Delete(int i)
        {
            if (IsEmpty() || i < 1)
            {
                throw new Exception("Error");
            }

            var l = Head;
            var r = Head.Next;
            var index = 1;
            while (r != null && index < i)
            {
                index++;
                l = r;
                r = r.Next;
            }
            if (index == i)
            {
                l.Next = r.Next;
                return r.Data;
            }
            else
            {
                throw new Exception("Error");
            }
        }

        //时间复杂度O(n)
        //第i个位置，从1开始
        public T GetElement(int i)
        {
            if (IsEmpty() || i < 1)
            {
                throw new Exception("Error");
            }

            var node = Head.Next;
            var index = 1;
            while (node != null && index < i)
            {
                node = node.Next;
                index++;
            }
            if (index == i)
            {
                return node.Data;
            }
            else
            {
                throw new Exception("Error");
            }
        }

        //时间复杂度O(n)
        //返回值从0开始
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                return -1;
            }
            var index = 0;
            var node = Head.Next;
            while (!node.Data.Equals(value) && node.Next != null)
            {
                node = node.Next;
                index++;
            }
            if (node.Data.Equals(value))
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        //时间复杂度O(n)
        public void Reverse()
        {
            if (IsEmpty())
            {
                return;
            }
            var node = Head.Next;
            while (node != null)
            {
                Head.Next = new Node<T>(node.Data, Head.Next);
                node = node.Next;
            }
        }

    }
}
