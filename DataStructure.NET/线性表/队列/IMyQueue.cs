using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public interface IMyQueue<T>
    {
        int GetLength();
        bool IsEmpty();
        void Clear();
        void In(T item);
        T Out();
        T GetFront();
    }
}
