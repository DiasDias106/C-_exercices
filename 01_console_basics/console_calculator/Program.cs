using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("introduza a operação que pretende executar");
            string op = Console.ReadLine();
            int x = 2, y = 3;
            func f = null;
            switch (op)
            {
                case "+":
                    f = (a, b) => a + b;
                    break;
                case "-":
                    f = (a, b) => a - b;
                    break;
                case "*":
                    f = (a, b) => a * b;
                    break;
                case "/":
                    f = (a, b) => a / b;
                    break;
                default:
                    Console.WriteLine("operação invalida");
                    break;
            }

                    if (f != null) { f(x, y); }
                    Console.WriteLine(f(x,y));
                    Console.ReadLine();
            }
        }
    }
