using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa la temperatura actual");

            string temperatura = Console.ReadLine();
            int numTemperatura;//= int.Parse(temperatura);lo haceos dentro del if

            int numero;
            if(int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("El valor ingresado no es valido,se establecio que la temperatura sea 0");
            }


            if (numTemperatura < 20)
            {
                Console.Write("Abrigate");

            }
            else if (numTemperatura == 20)
            {
                Console.WriteLine("Vistete comodo");
            }
            else if (numTemperatura == 30)
            {
                Console.WriteLine("Hacen 30 grados, !que calor!");
            }

            else //if (numTemperatura > 20) no hace falta
            {
                Console.WriteLine("Usa ropa mas bien liviana");
            }
            Console.Read();

        }
    }
}
