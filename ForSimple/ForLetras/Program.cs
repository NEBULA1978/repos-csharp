using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            //for letras
            char letra;

            for (letra = 'a'; letra <= 'z'; letra++)
            {
                Console.WriteLine(letra);
            }
            Console.ReadKey();
        }
    }
}
