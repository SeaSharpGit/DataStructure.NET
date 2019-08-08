using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class DoubleLinkTreeNode<T>
    {
        public T Data { get; set; } = default;
        public DoubleLinkTreeNode<T> LeftChild { get; set; } = null;
        public DoubleLinkTreeNode<T> RightChild { get; set; } = null;

        public DoubleLinkTreeNode(T data)
        {
            Data = data;
        }

        public DoubleLinkTreeNode(T data, DoubleLinkTreeNode<T> left, DoubleLinkTreeNode<T> right)
        {
            Data = data;
            LeftChild = left;
            RightChild = right;
        }

        public DoubleLinkTreeNode()
        {

        }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        /// <returns></returns>
        public bool IsLeaf() => LeftChild == null && RightChild == null;

    }
}
