using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paridade_de_numeros
{
    internal class Comparar
    {
        public static int paridade(int i)
        {
            int n = i % 2;
            if (n == 0)
            {
                Console.WriteLine("o numero introduzido e par");
                return n;
            }
            else
            {
                Console.WriteLine("o numero introduzido é impar");
                return n;
            }
        }
    }
}
