using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public class DoubleLinkTree<T>
    {
        public DoubleLinkTreeNode<T> Root { get; set; } = null;

        public DoubleLinkTree()
        {

        }

        public DoubleLinkTree(DoubleLinkTreeNode<T> root)
        {
            Root = root;
        }

        public bool IsEmpty() => Root == null;

        public static void InsertLeft(T data, DoubleLinkTreeNode<T> node)
        {
            node.LeftChild = new DoubleLinkTreeNode<T>(data, node.LeftChild, null);
        }

        public static void InsertRight(T data, DoubleLinkTreeNode<T> node)
        {
            node.RightChild = new DoubleLinkTreeNode<T>(data, node.RightChild, null);
        }

        public static DoubleLinkTreeNode<T> DeleteLeft(DoubleLinkTreeNode<T> node)
        {
            if (node?.LeftChild == null)
            {
                return null;
            }
            var result = node.LeftChild;
            node.LeftChild = null;
            return result;
        }

        public static DoubleLinkTreeNode<T> DeleteRight(DoubleLinkTreeNode<T> node)
        {
            if (node?.RightChild == null)
            {
                return null;
            }
            var result = node.RightChild;
            node.RightChild = null;
            return result;
        }

    }
}
