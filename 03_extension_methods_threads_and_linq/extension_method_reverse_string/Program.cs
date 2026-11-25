using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_extensão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("incira string");
            string valor = Console.ReadLine();
            Console.WriteLine(Mentor.reverter(valor));
            Console.ReadLine();
        }
    }
}
