using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{//esta por 2h15 del video
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese la temperatura actual");

            string temperatura = Console.ReadLine();
            int numTemperatura = int.Parse(temperatura);


            if(numTemperatura < 20)
            {
                Console.WriteLine("Abrigate!");
            }
            if (numTemperatura == 20)
            {
                Console.WriteLine("vistete comodo");
            }
            if (numTemperatura > 20) 
            
            {
                Console.WriteLine("Usa ropa mas liviana");
            }
            Console.Read();
        }
    }
}
