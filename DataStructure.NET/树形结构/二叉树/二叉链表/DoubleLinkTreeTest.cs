using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public static class DoubleLinkTreeTest<T>
    {
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

    }
}
