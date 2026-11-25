using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_pontos
{
    internal class Pontos
    {
        public int Ponto { get; set; }
        public Pontos(int npontos) {
            this.Ponto = npontos;
        }
        public void unlock(int Pontos)
        {
            if(Ponto >= 100)
            {
                Console.WriteLine("conquista desbloqueada");
            }
        }
    }
}
