using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia_geral
{
    internal class Dados
    {
        #region overload
        //string[] Nome = new string[5];
        //int[] numero = new int[5];
        //int[] nota = new int[5];

        //public Dados(string[] pnome, int[] pnumero)
        //{
        //    for(int i = 0; i < 5; i++)
        //    {
        //        this.Nome[i] = pnome[i];
        //        this.numero[i] = pnumero[i];
        //    }
        //}
        //public Dados(string[] pnome, int[] pnumero, int[] nota) : this(pnome, pnumero)
        //{
        //    for (int i = 0; i < 5; i++)
        //    {
        //        this.nota[i] = nota[i];
        //    }
        //}
        #endregion
        #region overide
        public override string ToString()
        {
            return $" A tua prima";
        }

        public virtual void ver()
        {
            Console.WriteLine(ToString());
        }





        #endregion
    }
}
