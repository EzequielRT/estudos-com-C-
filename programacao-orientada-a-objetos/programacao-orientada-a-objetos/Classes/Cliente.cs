using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cliente
    {
        /// <summary>
        /// Construtor com tres parametros
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="cpf"></param>
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
        }

        /// <summary>
        /// Constriutor com parametro telefone inteiro
        /// </summary>
        /// <param name="telefone">telefone inteiro</param>
        public Cliente(int telefone)
        {
            this.Telefone = telefone.ToString();
        }

        /// <summary>
        /// Construtor sem parametros
        /// </summary>
        public Cliente() { }
        
        public static string Teste;
        
        public string Nome;
        public string Telefone;
        public string CPF;

        public void Gravar()
        {
            //TODO implementar
        }

        private static string caminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            if (File.Exists(caminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(caminhoBaseClientes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente { clienteArquivo[0], clienteArquivo[1], clienteArquivo[2] };
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }
    }
}
