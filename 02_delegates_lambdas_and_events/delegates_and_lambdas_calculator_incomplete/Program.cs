using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace delegates_e_landas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("varias operações");
            Console.WriteLine("introduza um numero");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduza outro numero");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduza a operação desejada");
            string op = Console.ReadLine();
            func sefe;
            switch(op)
            {
                case "+":
                    sefe = (a, b) => a + b;
                    break;
                case "-":
                    sefe = (a,b) => a - b;
                    break;
                case "*":
                    sefe = (a,b) => a * b;
                    break;
                case "/":
                    sefe = (a,b) => (a / b);
                    break;
                case "%":
                    sefe = (a, b) => a % b;
                    break;
                default:
                    Console.WriteLine("operacao invalida");
                    break;
            }
            if (sefe != null) { Console.WriteLine(sefe(x, y)); }
        }
    }
}
