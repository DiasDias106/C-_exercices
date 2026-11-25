using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descontos_loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            loja cliente1 = new loja();
            Console.WriteLine("introduza a quantia desejada");
            float q = Convert.ToInt32(Console.ReadLine());
            cliente1.descontar(q);
            Console.ReadKey();
        }
    }
}
