using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Usar_threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Utelizacao.ativar1));
            thread1.Start();

            Thread thread2 = new Thread(new ParameterizedThreadStart(Utelizacao.ativar2));
            thread2.Start("thread com parametro");

            thread1.Join();
            thread2.Join();

            Console.WriteLine("as threads terminaram");
            Console.ReadKey();
        }
    }
}
