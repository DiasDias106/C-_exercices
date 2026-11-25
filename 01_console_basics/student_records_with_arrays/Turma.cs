using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alunos_dados
{
    internal class Turma
    {
        public string[] Nome = new string[5];
        public string[] Turmas = new string[5];
        public int[] Notas = new int[5];

        public void dados()
        {
            for (int i = 0; i < Nome.Length; i++)
            {
                Console.WriteLine("introduza uma nome");
                Nome[i] = Console.ReadLine();
                Console.WriteLine("introduza a turma");
                Turmas[i] = Console.ReadLine();
                Console.WriteLine("introduza a nota");
                Notas[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Turmas.Length; i++)
            {
                Console.WriteLine($"nome{Nome[i]} Turma{Turmas[i]} Nota{Notas[i]}");
                Console.ReadLine();
            }
        }
    }
}
