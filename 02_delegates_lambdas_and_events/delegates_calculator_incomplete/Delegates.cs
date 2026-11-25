using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_e_calculadora
{
    public delegate void tuaprima(string n, string f);
    public delegate int opera(string n, int t);
    public delegate int encargos(int h, int j);
    internal class Delegates
    {
        public static int soma(string n,int t)
        {
            int y= Convert.ToInt32(n);
            int soma = y + t;
            Console.WriteLine(soma);
            return soma;
        }
        public static void operalimoes(int h,int j)
        {
            Console.WriteLine("operações naturais da matematica");
            string op = Console.ReadLine();
            encargos top;
            Console.WriteLine("incira um numero");
            int po = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("incira outro numero");
            int pa = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case "+":
                    top = (h,j) => h + j;
                    break;
            }

        }
    }
}
