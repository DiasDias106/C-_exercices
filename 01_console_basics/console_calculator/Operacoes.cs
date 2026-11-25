using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public delegate void opera(int a, int b);
    public delegate int func(int a, int b);

    internal class Operacoes
    {
        public static void soma(int a, int b)
        {
            int soma = a + b;
        }

    }
}
