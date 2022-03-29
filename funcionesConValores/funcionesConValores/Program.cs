using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionesConValores
{
    class Program
    {
        static void Main(string[] args)
        {

            Calcular();
            Console.Read();

        } 
        public static void Calcular()
        {
            Console.WriteLine("Porfavor, ingresa un numero");
            string numeroInput = Console.ReadLine();
            Console.WriteLine("Porfavor ingresa otro un numero");
            string numero2Input = Console.ReadLine();

           
            int num1 = int.Parse(numeroInput);//convertimos string a entero con Parse
            int num2 = int.Parse(numero2Input);

            int resultado = num1 + num2;
            Console.WriteLine(resultado);
        }
    }
}
