using Classes;
using Componentes;
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
            Menu.Criar();
        }
    }
}


#region Códigos de testes das aulas de Orientação a Objetos

/*
    Email.Instancia.Corpo = "bla bla bla";
    Email.Instancia.Titulo = "Titulo do email";
    Email.Instancia.Origem = "ezefuts@gmail.com";
    Email.Instancia.Destino = "paola@gmail.com";

    Email.Instancia.EnviarEmail();

    class Animal
    {
        public string teste;
    }

    public virtual string teste2()
    {
        return "";
    }
  
    class Macaco : Animal
    {
        public override string teste2()
        {
            return "sss";
        }
    }

    partial class Animal
    {
       public string teste;
       partial void tt();
    }

    partial class Animal
    {
        public string teste2;
        partial void tt()
        {
            Console.Write("teste");
        }
    } 


    var a = new Animal();

    a.teste = "";
            
    var c  = new Cachorro();
    c.Idade = 1;
    Console.WriteLine(c.Idade);

    c.Idade2 = 1;

    Console.WriteLine(c.Idade2);

    Console.ReadLine();

            
    var cachorro = new Cachorro();
    cachorro.Latir();

    Menu.Criar();

    Console.WriteLine("================Cadastro de Cliente===================");
    Cliente c = new Cliente();
    c.Nome = "Cliente";
    c.Telefone = "23333";
    c.CPF = "888885";
    c.Gravar();

    foreach (Cliente cl in new Cliente().Ler())
    {
        Console.WriteLine(cl.Nome);
        Console.WriteLine(cl.Telefone);
        Console.WriteLine(cl.CPF);
        Console.WriteLine("===================================");
    }

    Console.WriteLine("================Cadastro de Usuario===================");
    Usuario u = new Usuario();
    u.Nome = "Usuario";
    u.Telefone = "111615165";
    u.CPF = "14416515616";
    u.Gravar();

    foreach (Usuario us in new Usuario().Ler())
    {
        Console.WriteLine(us.Nome);
        Console.WriteLine(us.Telefone);
        Console.WriteLine(us.CPF);
        Console.WriteLine("===================================");
    }

    Ferramentas f = new Ferramentas();
    bool d = f.ValidarCPF("valida cpf");

    Cliente c = new Cliente();
    c.CalcularUmMaisDois4();
*/

#endregion