using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1 = new Dados("To kim",1 , 18 ,"mercenario");
            pessoa1.ver();
            Console.ReadLine();
        }
    }
}
