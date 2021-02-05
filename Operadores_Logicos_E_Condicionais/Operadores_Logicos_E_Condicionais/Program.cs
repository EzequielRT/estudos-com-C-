using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos_E_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------ELSE-IF------------------------
            var a = 2;
            if (a == 1)
            {
                Console.WriteLine("Entrou na condição do if");
            }
            else if (a == 2)
            {
                Console.WriteLine("Caiu no bloco do senão se a = 2");
            }
            else
            {
                Console.WriteLine("Caiu no bloco do else");
            }

            //------------------------SWITCH-CASE------------------------

            var b = 3;
            switch (b)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            //------------------------OPERADOR-TERNARIO------------------------

            var x = 2;
            string teste = (x == 1 ? "X é igual a 1" : "X é diferente de 1");

            Console.WriteLine(teste);

            Console.ReadLine();
        }
    }
}
