using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Abr23
{
    public class Aluno
    {
        [Key]
        [Range(maximum: 1000, minimum: 1, ErrorMessage = "Número Inválido")]
        public int Num { get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }

        public override string ToString()
        {
            return $"Num:{Num,3}\tNome:{String.Format("{0,-34}",Nome)}\tTurma:{Turma,2}";
        }

    }

    public class Nota
    {
        public int Num { get; set; }
        public string Disciplina { get; set; }
        public int Nivel { get; set; }

        public override string ToString()
        {
            return $"Num:{Num}\t\tDisciplina:{Disciplina}\t\tClassificação:{Nivel.ToString("00")}";
        }
    }
    internal class BD
    {
        public List<Aluno> alunos;
        public List<Nota> notas;
        public BD()
        {
            alunos = new List<Aluno>() {
                new Aluno() {Num=1, Nome="Zé Carioca", Turma="A"},
                 new Aluno() {Num=2, Nome="Tio Patinhas", Turma="B"},
                  new Aluno() {Num=3, Nome="Pato Donald", Turma="A"},
                   new Aluno() {Num=4, Nome="Margarida", Turma="B"},
                    new Aluno() {Num=5, Nome="Minnie", Turma="A"},
                     new Aluno() {Num=6, Nome="Mickey", Turma="A"},
            };

            notas = new List<Nota>()
            {
                new Nota() {Num=1,Disciplina="Mat",Nivel=12},
                new Nota() {Num=1,Disciplina="Port",Nivel=10},
                new Nota() {Num=1,Disciplina="Prog",Nivel=19},
                new Nota() {Num=2,Disciplina="Mat",Nivel=11},
                new Nota() {Num=2,Disciplina="Port",Nivel=8},
                new Nota() {Num=3,Disciplina="Mat",Nivel=9},
                new Nota() {Num=4,Disciplina="Mat",Nivel=11},
                new Nota() {Num=5,Disciplina="Mat",Nivel=15},
                new Nota() {Num=6,Disciplina="Mat",Nivel=6}
            };
        }
    }
}
