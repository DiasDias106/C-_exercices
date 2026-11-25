using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            opera dlg = Calc.soma;
            //dlg += delegate (int x, int y)
            //{
            //    int multi = x * y;
            //    Console.WriteLine($"multiplicação : {multi}");
            //};
            dlg += (x, y) => { Console.WriteLine($"multiplicação : {x * y}"); };
            dlg(7, 4);
            Console.ReadKey();
        }
    }
}
