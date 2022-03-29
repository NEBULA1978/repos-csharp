using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDoWhile//almenos una vez se va a chequear aunque no se cumpla la condicon
{
    class Program
    {
        static void Main(string[] args)
        {
           // int contador = 0;
            int largoDeTexto = 0;
            string textoCompleto = "";
            do
            {
                Console.WriteLine("Por favor,ingresa el nombre de un amigo");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;
                //    Console.WriteLine(contador);
                //    contador++;
                //  } while (contador < 5);
                //  Console.Read();
                  } while (largoDeTexto < 20);
            Console.WriteLine("Gracias, eso es todo " + textoCompleto);
                  Console.Read();
                  }
            }
}
