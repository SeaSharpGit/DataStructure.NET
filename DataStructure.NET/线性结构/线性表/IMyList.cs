using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    public interface IMyList<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Append(T item);
        void Insert(T item, int i);
        T Delete(int i);
        T GetElement(int i);
        int Locate(T value);
        void Reverse();
    }
}
