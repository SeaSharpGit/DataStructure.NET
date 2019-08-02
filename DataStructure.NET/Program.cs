using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<string, int>> test = a => a.Length;
            var b = Expression.Constant(1);
            var c = Expression.Constant(2);
            var d = Expression.Add(b, c);
            Console.WriteLine(d);

            Func<string, int> func = a => a.Length;

            Expression<Func<string, int>> expression = a => a.Length;
            expression.Compile();
        }

    }
}
