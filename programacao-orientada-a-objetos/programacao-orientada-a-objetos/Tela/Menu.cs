using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA_PROGRAMA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;

        public static void Criar()
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
                    "\n      3 - Para Calcular Media de Alunos" +
                    "\n      4 - Cadastrar clientes";
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
                    Arquivo.Ler(1);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (valor == TABUADA_PROGRAMA)
                {
                    Console.WriteLine("============== Opção Tabuada ==============");
                    Console.WriteLine("Digite o numero que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Console.WriteLine("============== Opção Calculo da Média ==============");
                    Media.Aluno();
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                Console.WriteLine("============== Opção Cadastrar Clientes ==============");
                TelaCliente.Chamar();
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
    }
}
