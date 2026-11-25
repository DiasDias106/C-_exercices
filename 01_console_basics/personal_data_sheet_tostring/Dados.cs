using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha_de_dados
{
    internal class Dados
    {
        private string nome;
        private int numero;
        private int idade;
        private string proficao;

        public string Nome { get; set; }
        public int Numero
        {
            get { return numero; }
            set { if (value > 0 && value <= 100) numero = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { if (value > 0 && value < 110) idade = value; }
        }
        public string Proficao { get; set; }

        public Dados(string pnome, int pnumero, int pidade, string pproficao)
        {
            this.Nome = pnome;
            this.Numero = pnumero;
            this.Idade = pidade;
            this.Proficao = pproficao;
        }
        public override string ToString()
        {
            return $" Nome{Nome} \t Numero{Numero} \t Idade{Idade} \t Profissão{Proficao}";
        }
        public virtual void ver()
        {
            Console.WriteLine("Ficha com os seus dados");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(ToString());
            Console.WriteLine("Fim da ficha");
        }
    }
}
