using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_linq
{
    internal class Aluno
    {
        public int Num { get; set; }
        public String Nome { get; set; }
        public String Turma { get; set; }

        public override string ToString()
        {
            return $"{Num} - {Nome} Turma: {Turma}";
        }
    }

    public class Exame
    {
        public int Num { get; set; }
        public String Disciplina { get; set; }

        public int Nota { get; set; }

        public override string ToString()
        {
            return $" Aluno:{Num} disc:{Disciplina} Nota:{Nota}";
        }
    }
    internal class BD
    {
    }
}
