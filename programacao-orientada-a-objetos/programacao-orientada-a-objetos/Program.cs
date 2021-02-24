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

            var clientes = Cliente.LerClientes();  // dados estáticos

            var cliente = new Cliente();  // dados instanciados
            cliente.Nome = "danilo";
            cliente.Telefone = "515558184949";
            cliente.Telefone = "1515191859";
            cliente.Gravar();

            /*var cliente2 = new Cliente();  // dados instanciados
            cliente2.Nome = "sheila";
            cliente2.Telefone = "51564615191";
            cliente2.Telefone = "6515615919";
            cliente2.Gravar();
            */
        }
    }
}
