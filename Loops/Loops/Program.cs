using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
          //------------------------WHILE------------------------

         /* int a = 1;
            while(a <= 10) 
            {
                if (a == 5) 
                {
                    a++;
                    continue
                  //break; -> FINALIZA A OPERAÇÃO
                }
                Console.WriteLine(a);
                a++;
            }

            Console.ReadLine(); */

          //------------------------DO-WHILE------------------------

         /* int a = 1;
            do
            {
                if (a == 3) 
                {
                   break;
                }
                Console.WriteLine(a);
                a++;
            }
            while (a <= 10); 
         
            Console.ReadLine();*/

          //------------------------FOR------------------------

         /* for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine(); */

          //------------------------FOREACH------------------------

         /* int[] a = { 1, 2, 3, 4, 5 };

            foreach (int valor in a)
            {
                Console.WriteLine(valor);
            }

            //Mesmo exemplo usando FOR:
            Console.WriteLine("-----------------");

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.ReadLine(); */

            Looping(1);
            Console.ReadLine();
        }

        //------------------------FUNCAO-RECURSIVA------------------------

        public static void Looping(int a)
        {
            Console.WriteLine(a);
            if (a < 5) 
            {   
                Looping(a + 1);
            }
        }
    }
}
