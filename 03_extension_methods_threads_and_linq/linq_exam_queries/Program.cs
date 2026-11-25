using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_linq
{
    internal class Program
    {
        static List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno { Num = 1, Nome = "Tio Patinhas", Turma = "A" },
            new Aluno { Num = 2, Nome = "Pato Donald", Turma = "B" },
            new Aluno { Num = 3, Nome = "Vovó Donald", Turma = "A" },
            new Aluno { Num = 4, Nome = "Peninha", Turma = "B" },
            new Aluno { Num = 5, Nome = "Zé Carioca", Turma = "A" }
        };

        private static List<Exame> exames = new List<Exame>()
        {
            new Exame { Num = 1, Disciplina = "ProgII", Nota = 12 },
            new Exame { Num = 1, Disciplina = "BD", Nota = 9 },
            new Exame { Num = 1, Disciplina = "Redes", Nota = 11 },
            new Exame { Num = 2, Disciplina = "ProgII", Nota = 12 },
            new Exame { Num = 2, Disciplina = "BD", Nota = 16 },
            new Exame { Num = 2, Disciplina = "Redes", Nota = 17 },

            new Exame { Num = 3, Disciplina = "BD", Nota = 10 },
            new Exame { Num = 3, Disciplina = "Redes", Nota = 11 },
            new Exame { Num = 4, Disciplina = "ProgII", Nota = 9 },
            new Exame { Num = 4, Disciplina = "Redes", Nota = 15 },
        };

        static void Main(string[] args)
        {
            //Alunos da turma A
            //var disciplinas = exames.Select(e => e.Disciplina).Distinct()
            //    .Where(z=>z.Contains("r"))
            //    .OrderBy(d => d);
            //foreach(var d in disciplinas) Console.WriteLine($"{d}");
            var delta = alunos.Join(
                exames,
                a => a.Num,
                e => e.Num,
                (al, ex) => new
                {
                    Num = al.Num,
                    Nome = al.Nome,
                    Turma = al.Turma,
                    Disciplina = ex.Disciplina,
                    Nota = ex.Nota

                }
            ).GroupBy(
                x => x.Turma,
                x => x,
                (k, g) => new {
                    Turma = k,
                    Media = g.Average(x => x.Nota),
                    TotalExames = g.Count(),
                    Positivas = g.Count(x => x.Nota >= 10)
                }
            ).OrderByDescending(e => e.Media);

            foreach (var i in delta) Console.WriteLine($"{i.Turma} " +
                                                       $"Média:{i.Media:0.00} TotalExames:{i.TotalExames} Posis:{i.Positivas}");
        }
    }
}
