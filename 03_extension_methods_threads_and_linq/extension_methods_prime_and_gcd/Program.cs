using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_de_extensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduza 2 numeros");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool ver = num1.numprimo();
            int mdc = num1.maxdiv(num2);
            Console.WriteLine($"o numero e primo? : {ver}");
            Console.WriteLine($"o maximo divisor comum : {mdc}");

        }
    }
}
