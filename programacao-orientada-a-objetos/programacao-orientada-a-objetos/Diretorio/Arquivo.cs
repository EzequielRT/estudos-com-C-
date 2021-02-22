using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Diretorio
{
    class Arquivo
    {
        public static void Ler(int numeroArquivo)
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
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
