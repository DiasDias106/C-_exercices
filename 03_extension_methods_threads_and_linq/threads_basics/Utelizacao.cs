using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Usar_threads
{
    internal class Utelizacao
    {
        public static void ativar1()
        {
            Console.WriteLine("thread 1 iniciou");
            Thread.Sleep(2000);
            Console.WriteLine("a thread 1 terminou");
        }
        public static void ativar2(object palavra)
        {
            Console.WriteLine("thread 2 iniciou");
            Thread.Sleep(1000);
            Console.WriteLine("thread 2 terminou");
        }
    }
}
