using Abr23;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abr23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BD bD = new BD();
            bD.alunos.Add(new Aluno() { Num=100,Nome="Pateta", Turma="B"});
            Aluno morto = bD.alunos.Where(x=>x.Nome.Equals("Zé Carioca")).FirstOrDefault(); 
            if(morto!=null)bD.alunos.Remove(morto);

            morto = bD.alunos.Find(x=>x.Num==100);
            if (morto != null) bD.alunos.Remove(morto);
            var alfa = from a in bD.alunos
                       orderby a.Nome descending
                       //where a.Turma.Equals("A")
                       select a;

            Aluno editada = bD.alunos.Find(x => x.Nome.Equals("Margarida"));
            if (editada != null) editada.Nome = "Margarida, namorada do Donald";
            foreach (var a in alfa) Console.WriteLine($"{a.ToString(),44}");

            Console.WriteLine("\n\n\n--------------------(Totais)---------------------");
            var bravo = from a in bD.alunos
                        group a by a.Turma
                        into G
                        select new { Turma = G.Key, Total = G.Count(), Alunos = G };

            foreach(var b in bravo)
            {
                Console.WriteLine($"\t\t::::::::::::::::::::::::::: TURMA:{String.Format("{0,-2}",b.Turma)} Total de alunos {b.Total}");
                foreach(var a in b.Alunos) Console.WriteLine($"{a.ToString(),33}");
            }
            Console.WriteLine("--------------------(Estatística)---------------------");

            //Moste o Nome de cada aluno, total de notas, média das notas, contar de negas,
            //                   nota máxima e nota mínima e por baixo desta linha
            //                   de estatística por aluno, mostre a lista das respetivas
            //                   disciplinas e níveis. 
            var charlie = from a in bD.alunos
                          join n in bD.notas
                          on a.Num equals n.Num
                          let dado = new { Num = a.Num, Nome = a.Nome, Disciplina = n.Disciplina, Nivel = n.Nivel }
                          group dado by dado.Nome
                          into G
                          select new {Nome=G.Key, Total=G.Count(), Media=G.Average(x=>x.Nivel).ToString("00.00"), 
                                       Negas=G.Count(x=>x.Nivel<10), Max=G.Max(x=>x.Nivel) , Min = G.Min(x=>x.Nivel), 
                              Notas=G };

            foreach(var c in charlie)
            {
                Console.WriteLine($"Nome:{String.Format("{0,-24}",c.Nome)}\t Total:{c.Total}\t" +
                    $" Média:{c.Media} Negas:{c.Negas}  Max:{c.Max} Min:{c.Min}   ");

                foreach(var s in c.Notas) Console.WriteLine($"\n {s.Disciplina}::{s.Nivel}");
                Console.WriteLine("\n---------------------------------------------------------------------\n");
            }



            Console.ReadLine();
        }
    }
}


//var charlie = from a in bD.alunos
//              join n in bD.notas
//              on a.Num equals n.Num
//              let dado = new { Num = a.Num, Nome = a.Nome, Turma = a.Turma, Disciplina = n.Disciplina, Nivel = n.Nivel }
//              group dado by dado.Nome
//                         into G
//              select new { Nome = G.Key, Total = G.Count(), Negas = G.Count(x => x.Nivel < 10), Media = G.Average(x => x.Nivel), Dados = G };

//foreach (var c in charlie)
//{
//    Console.WriteLine($"{c.Nome} Média:{c.Media.ToString("00.00")} Count:{c.Total}  Negas:{c.Negas}");
//    foreach (var d in c.Dados) Console.WriteLine($"{d.Disciplina}->{d.Nivel}");
//    Console.WriteLine("\n-------------------------------------------------------\n");

//}