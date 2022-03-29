using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeErrores
{//1h 54 minutos mirar fallos nomesale no se puede divir por cero
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingresa un numero");
            string valorIngresado = Console.ReadLine();

            int num1 = 5;
            int num2 = 9;
            int resultado;

            
            try
            {
                resultado = num1 / num2;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("No se puede dividir por cero");
            }


            try
            {
                int valorComoInt = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorreco");

                throw;
            }
            catch(OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado  largoo demasiado corto");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningun valor");
            }
            finally
            {
                Console.WriteLine("Esta frase aparecera pase lo que pase");
            }

            Console.Read();
        }
    }
}
