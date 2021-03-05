using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Cachorro : Animal
    {
        public int Idade;

        private int IdadePreDefinida = 2;

        public int Idade2 
        { 
            get 
            { 
                return IdadePreDefinida; 
            } 
            set
            {
                IdadePreDefinida = value;
            }
        }

        public override void Latir()
        {
            Console.WriteLine("Au eu sou um cachorrinho");
        }
    }
}
