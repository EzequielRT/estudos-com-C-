using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_e_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------ARRAY--------------------------

            /* string[] a = new string[3];
               a[0] = "Danilo";
               a[1] = "Paola";
               a[2] = "Jose";

               Array.Sort(a); // Ordena o Array em ordem alfabética

               foreach (string nome in a)
               {
                   Console.WriteLine(nome);
               }
                
               int size = a1.Length; // Seta o tamanho do Array
               if (Array.Exists(a1, e=>e.IndexOf("Dani") != -1)) // Procura por parte da string no Array
               {
                   Console.WriteLine("Existe o Danilo1 no meu Array.");
               }

               Console.ReadLine(); */

            // ------------------------COLLECTION------------------------

            List<string> a = new List<string>();
            a.Add("Danilo");
            a.Add("Jose");
            a.Add("Paola");

            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }

            if (a.Exists(e => e == "Danilo")) // Procura "Danilo" na Colletion
            {
                Console.WriteLine("Encontrei o danilo no meu collection list.");
            }

            int size_list = a.Count; // Seta o tamanho da Collection

            Console.ReadLine();
        }
    }
}
