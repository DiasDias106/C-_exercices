using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_e_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            opera ela = Delegates.soma;
            ela += delegate(string a, int b)
            {
                if (b == 0 && a == "") 
                {
                    Console.WriteLine("valores invalidos");
                    return -1;
                }
                else
                {
                    int c = Convert.ToInt32(a);
                    Console.WriteLine($"multiplicação{c * b}");
                    return c * b;
                }
            };
            ela("50", 10);
            Console.ReadLine();
        }
    }
}
