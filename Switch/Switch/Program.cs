using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch

            byte dia;
            Console.WriteLine("Dame un dia; ");
            dia = Convert.ToByte(Console.ReadLine());

            switch(dia)
            {
                case 1: Console.WriteLine("Has elegido el Lunes"); break;
                case 2: Console.WriteLine("Has elegido el Martes"); break;
                case 3: Console.WriteLine("Has elegido el Miercoles"); break;
                case 4: Console.WriteLine("Has elegido el Jueves"); break;
                case 5: Console.WriteLine("Has elegido el Viernes"); break;
                case 6: Console.WriteLine("Has elegido el Sabado"); break;
                case 7: Console.WriteLine("Has elegido el Domingo"); break;
                default: Console.WriteLine("No es un dia de la semana"); break;
            }
            Console.ReadKey();

        }
    }
}
