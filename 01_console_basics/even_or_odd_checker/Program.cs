using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paridade_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("introduza um numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Comparar.paridade(numero);
            Console.ReadLine();
        }
    }
}
