using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio, total;
            int cantidad;

            //trycatch para no se caiga aplicacion cuando introduciomos una letra y sumamops numeros
            try
            {

                Console.WriteLine("cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                total = cantidad * precio;

                Console.WriteLine("El total es: " + total);

            }
            catch(Exception error)//catch(DivideByZeroException error) no esta permitida la / entre 0
            {
                Console.WriteLine("Ha ocurrido un error " + error.Message);
            }




            Console.ReadKey();//para poder ver la ventana espera hasta que pulsamos tecla
                 

        }
    }
}
