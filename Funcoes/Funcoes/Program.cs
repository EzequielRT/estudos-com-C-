using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int retorno = CalcularSoma(); // Funcao com retorno precisa ser instanciada

            Console.WriteLine(retorno);

            MostrarMensagemNaTela();

            Tabuada(5);
            Tabuada(9);
            Tabuada(56);

            Console.ReadLine();
        }

        static int CalcularSoma() // Funcao com retorno
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }

        public static void MostrarMensagemNaTela() // Funcao sem retorno e publica
        {
            Console.WriteLine("Olá pessoal!");
        }

        static void Tabuada (int numero) // Ex: Tabuada
        {
            Console.WriteLine("=================================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }
            Console.WriteLine("=================================");
        }
    }
}
