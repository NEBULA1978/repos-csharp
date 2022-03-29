using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch//2h 34 minuts video
{
    class Program
    {
        static void Main(string[] args)
        {
            int autos = 5;

            switch (autos)
            {
                case 0:
                    Console.WriteLine("Usted no paga impuestos");
                    break;
                case 1:
                    Console.WriteLine("usted paga €15");
                    break;
                case 2:
                    Console.WriteLine("Usted paga €30");
                    break;
                default:
                    Console.WriteLine("Usted paga 15€ por auto");
                    break;

            }
            if(autos == 0)
            {
                Console.WriteLine("Usted no paga impuestos");
            }else if(autos == 1)
            {
                Console.WriteLine("usted paga €15");
            }else if(autos == 2)
            {
                Console.WriteLine("Usted paga €30");
            }else
            {
                Console.WriteLine("Usted paga 15€ por auto");
            }

            string piedraPapelTijera = "piedra";

            switch (piedraPapelTijera)
            {
                case "piedra":
                    Console.WriteLine("Piedra mata a tijera");
                    break;
                case "Papel":
                    Console.WriteLine("Papel mata a piedra");
                    break;
                case "tijera":
                    Console.WriteLine("tijera mata a papel");
                    break;
                default:
                    Console.WriteLine("Ese elemnto no forma parte del juego");
                    break;
            }



            Console.Read();
        }
    }
}
