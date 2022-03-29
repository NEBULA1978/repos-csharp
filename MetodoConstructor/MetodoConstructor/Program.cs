using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos instancia
            Ventana calculadora = new Ventana();

            //   calculadora.Mostrar();

            ~Ventana();

            Console.ReadKey();
        }
    }

    class Ventana
    {
        private int ancho, altura;
        private string color;

        //metodo constructor
        public Ventana()
        {
            ancho = 15;
            altura = 20;
            color = "Rojo";
            Console.WriteLine("Funciona!");
        }

        public void Mostrar()
        {
            Console.WriteLine("La dimension de la ventana es: " + ancho + "x" + altura + " Y su color es: " + color);
        }

        //Metodo destructor limpiar basura o recurso que no voy a utilizar
        ~Ventana()
        {
            //  Console.WriteLine("Se destruyeron los recursos");
            System.Diagnostics.Trace.WriteLine("Se destruyeron  los recursos");
        }
    }
}
