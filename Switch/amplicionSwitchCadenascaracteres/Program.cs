using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amplicionSwitchCadenascaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            Console.WriteLine("Dame un dia: ");
            dia = Console.ReadLine();

            switch(dia)
            {
                case "lunes": Console.WriteLine("Has elegido el Lunes"); break;
                case "martes": Console.WriteLine("Has elegido el Martes"); break;
                case "miercoles": Console.WriteLine("Has elegido el Miercoles"); break;
                case "jueves": Console.WriteLine("Has elegido el Jueves"); break;
                case "vierenes": Console.WriteLine("Has elegido el Viernes"); break;
                case "sabado": Console.WriteLine("Has elegido el Sabado"); break;
                case "domingo": Console.WriteLine("Has elegido el Domingo"); break;
                default: Console.WriteLine("No es un dia de la semana"); break;



            }
            Console.ReadKey();
        }
    }
}
