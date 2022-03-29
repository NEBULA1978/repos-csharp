using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresRelacionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores relacionales <>=||!
           /* double peso;
            

            Console.WriteLine("Digita tu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            if(peso <= 100)
            {
                Console.WriteLine("tu peso es normal");
            }

            if (peso == 100)
            {
                Console.WriteLine("cumples con la condicion");
            }*/

            //operadores logicos

            double peso;
            byte edad;

            Console.WriteLine("Digita tu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digita tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();
            /*
            if (peso > 100 && edad >=15)
            {
                Console.WriteLine("tu peso es normal");
            }*/

            // or || con se se cumpla una de las 2 verdadero ;altGr y 1 ||
            if (peso > 100 || edad >= 15)
            {
                Console.WriteLine("tu peso es pesado");
            }
            else if (peso < 100 || edad <= 15)
            {
                Console.WriteLine("tu peso es aceptable");
            }


            Console.ReadKey();

        }
    }
}
