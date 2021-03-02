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

            Console.WriteLine("================ Cadastro de Cliente ===================");
            Cliente c = new Cliente();
            c.Nome = "sss";
            c.Telefone = "23333";
            c.CPF = "151615";
            c.Gravar();

            foreach (Cliente cl in Cliente.LerClientes())
            {
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.CPF);
                Console.WriteLine("===================================");
            }

            Console.WriteLine("================ Cadastro de Usuario ===================");
            Usuario u = new Usuario();
            u.Nome = "sss";
            u.Telefone = "23333";
            u.CPF = "151615";
            u.Gravar();

            foreach (Usuario us in Usuario.LerUsuarios())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("===================================");
            }
            Console.ReadLine();
        }
    }
}
