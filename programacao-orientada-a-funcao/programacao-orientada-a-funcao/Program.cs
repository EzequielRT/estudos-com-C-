using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacao_orientada_a_funcao
{
    class Program
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA_PROGRAMA = 2;
        public const int CALCULO_MEDIA = 3;

        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n  Utilizando Programação Funcional" +
                    "\n\n" +
                    "\n    Digite uma das opções abaixo:" +
                    "\n      0 - Sair do Programa" +
                    "\n      1 - Para Ler Arquivos" +
                    "\n      2 - Para Executar a Tabuada" +
                    "\n      3 - Para Calcular Media de Alunos";
                Console.WriteLine(mensagem);

                
                Console.Write("\nOpção escolhida: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("============== Opção Ler Arquivos ==============");
                    LerArquivos(1);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (valor == TABUADA_PROGRAMA)
                {
                    Console.WriteLine("============== Opção Tabuada ==============");
                    Console.WriteLine("Digite o numero que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============== Opção Calculo da Média ==============");
                    CalcularMediaAluno();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida, digite novamente!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        private static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("============ Lendo arquivo ============ \n" + arquivoComCaminho + "\n=====================");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }

            string arquivoComCaminho2 = @"C:\Arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }

        private static void Tabuada(int numero)
        {
            Console.WriteLine("============== Calculo da Tabuada do " + numero + " ==============");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("=================================");
        }

        private static void CalcularMediaAluno()
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
