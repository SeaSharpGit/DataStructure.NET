using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public static class DoubleLinkTreeTest<T>
    {
        /// <summary>
        /// 插入左节点，当前左节点作为新节点的左节点
        /// </summary>
        /// <param name="data"></param>
        /// <param name="node"></param>
        public static void InsertLeft(T data, DoubleLinkTreeNode<T> node)
        {
            node.LeftChild = new DoubleLinkTreeNode<T>(data, node.LeftChild, null);
        }

        /// <summary>
        /// 插入右节点，当前右节点作为新节点的左节点
        /// </summary>
        /// <param name="data"></param>
        /// <param name="node"></param>
        public static void InsertRight(T data, DoubleLinkTreeNode<T> node)
        {
            node.RightChild = new DoubleLinkTreeNode<T>(data, node.RightChild, null);
        }

        /// <summary>
        /// 删除左节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 删除右节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 先序遍历
        /// </summary>
        public static void ForEachDLR(DoubleLinkTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            ForEachDLR(node.LeftChild);
            ForEachDLR(node.RightChild);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        public static void ForEachLDR(DoubleLinkTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            ForEachLDR(node.LeftChild);
            Console.WriteLine(node.Data);
            ForEachLDR(node.RightChild);
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        public static void ForEachLRD(DoubleLinkTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            ForEachLRD(node.LeftChild);
            ForEachLRD(node.RightChild);
            Console.WriteLine(node.Data);
        }

        /// <summary>
        /// 层序遍历
        /// </summary>
        public static void ForEachLevel(DoubleLinkTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            var queue = new Queue<DoubleLinkTreeNode<T>>();
            queue.Enqueue(node);
            while (queue.Count() != 0)
            {
                var item = queue.Dequeue();
                Console.WriteLine(item.Data);
                if (item.LeftChild != null)
                {
                    queue.Enqueue(item.LeftChild);
                }
                if (item.RightChild != null)
                {
                    queue.Enqueue(item.RightChild);
                }
            }
        }



    }
}
