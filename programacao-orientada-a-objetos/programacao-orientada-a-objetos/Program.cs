using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace programacao_orientada_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu.Criar();

            Cliente.Teste = "sss";

            var cliente = new Cliente();  // dados instanciados
            cliente.Nome = "paola";
            cliente.Telefone = "515558184949";
            cliente.CPF = "1515191859";
            cliente.Gravar();

            //Cliente c = new Cliente();

            //Cliente c2 = new Cliente { Nome = "marcelo", Telefone = "515955181818", CPF = "88189116915" };

            var clientes = Cliente.LerClientes();  // dados estáticos
            foreach (Cliente c in clientes)
            {
                Console.WriteLine(c.Nome);
                Console.WriteLine(c.Telefone);
                Console.WriteLine(c.CPF);

                Console.WriteLine("==========================");
            }

            Console.ReadLine();


            //var l = new List<String>();

            /*var cliente2 = new Cliente();  // dados instanciados
            cliente2.Nome = "sheila";
            cliente2.Telefone = "51564615191";
            cliente2.Telefone = "6515615919";
            cliente2.Gravar();
            */
        }
    }
}
