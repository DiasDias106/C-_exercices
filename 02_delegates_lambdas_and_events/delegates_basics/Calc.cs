using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void opera(int a, int b);
    internal class Calc
    {
      public static void soma(int a, int b)
        {
            int soma = a + b;
            Console.WriteLine($"soma{soma}");
        }
    }
}
