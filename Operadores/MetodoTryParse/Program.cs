using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoTryParse//convetir strings en tipos de datos numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroComoString = "128";
            int valorParseado;

            bool exito = int.TryParse(numeroComoString, out valorParseado);
            //el valor booleano de retorno sera true si Parse es posible
            if (exito)
                Console.WriteLine("Parsing exitoso - el numero es " + valorParseado);
            else
                Console.WriteLine("Parsing fallido");

            //con float.TryParse
            string numeroComoString2 = "128";
            float valorParseado2;

            bool exito2 = float.TryParse(numeroComoString, out valorParseado2);
            //el valor booleano de retorno sera true si Parse es posible
            if (exito2)
                Console.WriteLine("Parsing exitoso - el numero es " + valorParseado2);
            else
                Console.WriteLine("Parsing fallido");

            Console.ReadKey();
        }
    }
}
