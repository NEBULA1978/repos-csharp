using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_aritmeticos_clase_match
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores aritmeticos
            int num=6, num2 = 5;

            Console.WriteLine("Ek resultado de la suma es: " + (num + num2));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ek resultado de la resta es: " + (num - num2));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ek resultado de la multiplicacion es: " + (num * num2));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ek resultado de la division es: " + (num / num2));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Ek resultado del modulo es: " + (num % num2));


            double num3, pot, resultado;

            Console.WriteLine("Digite el numero que quiere elevar: ");
            num3 = Convert.ToDouble(Console.ReadLine());//temgo convertir a double resultado escrito por usuario
            //sino me da fallo frase arriba

            Console.WriteLine("Digite el numero que quiere elevar: ");
            pot = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num3, pot);

            Console.WriteLine("Rl resultado es: " + resultado);

            //raiz cuadrada Sqrt
            Console.WriteLine("La raiz cuadrada de 49 es : " + Math.Sqrt(49));

            Console.ReadLine();
        }
    }
}
