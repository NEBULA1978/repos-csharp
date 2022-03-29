using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach para cada

            string nombre = "learnwtutorials";

            foreach(char letra in nombre)//por cada letra en la variable nombre
            {
                Console.Write(" " + letra + " ");
            }


            Console.ReadKey();
        }




    }

}
