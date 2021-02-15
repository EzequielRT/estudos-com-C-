using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine("\nDigite as " + qtdNotas + " notas do aluno " + nome + "\n");

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.Write("Digite a nota " + i + ": ");
                int nota = int.Parse(Console.ReadLine());
                notas.Add(nota);
                totalNotas += nota;
            }

            int media = totalNotas / notas.Count;
            Console.WriteLine("\nA média do aluno " + nome + " é: " + media + "\n");

            foreach (int nota in notas)
            {
                Console.WriteLine("Suas notas são:");
                Console.WriteLine("Nota: " + nota + "\n");
            }
        }
    }
}
