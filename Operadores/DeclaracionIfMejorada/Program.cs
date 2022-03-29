using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaracionIfMejorada
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura = -5;
            string estadoDelAgua;
            
         /*   if (temperatura < 0)
                estadoDelAgua = "solido";

            else 
                estadoDelAgua = "liquido";




            Console.WriteLine("El estado del agua es " + estadoDelAgua);
          //  Console.Read();

            temperatura += 30;

            //if en una sola linea
            estadoDelAgua = temperatura < 0 ? "solido" : "liquido";
         */
            //desafio

            temperatura += 150;
            estadoDelAgua = temperatura > 99 ? "gaseoso" : temperatura < 0 ? "solido" : "liquido";
           
            Console.WriteLine("El estado del agua es " + estadoDelAgua);
            Console.Read();

        }
    }
}
