using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string textoIngresado = "";


            while (textoIngresado.Equals("")) 
            {
                Console.WriteLine("Porfavor presione enter cada vez +" +
                    "que un alumno ingrese al bus.para finalizar ingrese otro valor");
                textoIngresado = Console.ReadLine();
                contador++;
                Console.WriteLine("Alumnos en el bus: {0}", contador);

            }
            Console.Read();
        }
    }
}
