using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    internal class Program
    {
        public delegate int mydig(ref int a, int b);
        public delegate bool mypredi(int a, int b);
        static void Main(string[] args)
        {
            //mydig func = delegate (ref int x, int y)
            //{
            //    x += y;
            //    return x;
            //};
            //int z = 4;
            //z = func(ref z, 3);
            //Console.WriteLine(z);
            int m = utelidades.charlie(12, 3, (a, b) => a > b);
            Console.WriteLine(m);
            Console.ReadLine();

        }

        public class utelidades
        {
            public static int charlie(int a, int b, mypredi p)
            {
                return p(a, b) ? a : b;
            }
        }
    }
}
