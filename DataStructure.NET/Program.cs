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

            //Console.WriteLine(Compute.Run("2+2"));
            //Console.WriteLine(Compute.Run("2-2"));
            //Console.WriteLine(Compute.Run("2*2"));
            //Console.WriteLine(Compute.Run("2/2"));

            Console.WriteLine(Compute.Run("2+2+2"));//6
            Console.WriteLine(Compute.Run("2+2-2"));//2
            Console.WriteLine(Compute.Run("2+2*2"));//6
            Console.WriteLine(Compute.Run("2+2/2"));//3

            Console.WriteLine(Compute.Run("2+2+2"));//6
            Console.WriteLine(Compute.Run("2-2+2"));//2
            Console.WriteLine(Compute.Run("2*2+2"));//6
            Console.WriteLine(Compute.Run("2/2+2"));//3

            Console.WriteLine(Compute.Run("2+2*2*2"));//10
            Console.WriteLine(Compute.Run("2+2*2/2+2*2+2"));//10

            Console.WriteLine(Compute.Run("22*22"));//484
            Console.WriteLine(Compute.Run("2+22*22+2"));//488
            Console.WriteLine(Compute.Run("22+22/22+222"));//245

            Console.WriteLine(Compute.Run("1+3*(22+22)/22+222"));//229
            Console.WriteLine(Compute.Run("(1+3)*4"));//16
            Console.WriteLine(Compute.Run("(1+3)"));//4


        }

    }
}
