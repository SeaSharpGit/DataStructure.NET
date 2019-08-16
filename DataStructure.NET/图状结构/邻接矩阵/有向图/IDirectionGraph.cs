using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    /// <summary>
    /// 有向图
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDirectionGraph<T>
    {
        int GetNodeNum();
        int GetEdgeNum();
        void SetEdge(MatrixNode<T> v1, MatrixNode<T> v2, int v);
        void DeleteEdge(MatrixNode<T> v1, MatrixNode<T> v2);
        bool IsEdge(MatrixNode<T> v1, MatrixNode<T> v2);
        int GetEdge(MatrixNode<T> v1, MatrixNode<T> v2);
    }
}
