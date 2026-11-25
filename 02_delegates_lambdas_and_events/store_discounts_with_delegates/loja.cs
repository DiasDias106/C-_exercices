using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descontos_loja
{
    public delegate void paga(float valor);
    internal class loja
    {
        public float Numero { get; set; }
        public float Desconto {  get; set; }
        public float Novo_valor {  get; set; }

        public float descontar(float Valor)
        {
            if(Valor <= 1000)
            {
                Desconto = (Valor) * 0.3f;
                Novo_valor = Valor - Desconto;
                Console.WriteLine(Desconto);
                Console.WriteLine(Novo_valor);
            }
            else if(Valor > 1000 && Valor <= 1500)
            {
                Desconto = (Valor) * 0.5f;
                Novo_valor = Valor - Desconto;
                Console.WriteLine(Desconto);
                Console.WriteLine(Novo_valor);
            }
            else
            {
                Desconto = (Valor) * 0.7f;
                Novo_valor = (Valor) - (Desconto);
                Console.WriteLine(Desconto);
                Console.WriteLine(Novo_valor);
            }
            return Novo_valor;
            
        }
    }
}
