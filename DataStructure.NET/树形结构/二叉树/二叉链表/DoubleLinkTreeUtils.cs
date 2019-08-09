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
            ForEachLDR(node.LeftChild);
            ForEachLDR(node.RightChild);
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
            var linkQueue = new LinkQueue<DoubleLinkTreeNode<T>>();
            linkQueue.In(node);
            while (!linkQueue.IsEmpty())
            {
                var item = linkQueue.Out();
                Console.WriteLine(item.Data);
                if (item.LeftChild != null)
                {
                    linkQueue.In(item.LeftChild);
                }
                if (item.RightChild != null)
                {
                    linkQueue.In(item.RightChild);
                }
            }



        }



    }
}
