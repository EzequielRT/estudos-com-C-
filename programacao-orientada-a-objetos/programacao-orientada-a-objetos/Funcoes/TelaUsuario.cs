using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            while (true)
            {
                string mensagem = "Digite uma das opções abaixo:\n" +
                    "\n      0 - Sair do cadastro" +
                    "\n      1 - Para cadastrar Usuarios" +
                    "\n      2 - Para listar Usuarios";
                Console.WriteLine(mensagem);

                Console.Write("\nOpção escolhida: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o nome do usuario:");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do usuario:");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do usuario:");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();
                }
                else
                {
                    var usuarios = new Usuario().Ler(); 
                    foreach (Usuario c in usuarios)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);
                        Console.WriteLine("==========================");
                    }
                }
            }
        }
    }
}
