using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos intstancia
            Ventana calculadora = new Ventana();

            //creamos intstancia
            Ventana yeaaa = new Ventana();

            calculadora.Cerrar();

            Console.WriteLine("------------------------------------------------");

            calculadora.Minimizar();

            Console.WriteLine("------------------------------------------------");

            calculadora.Maximizar();

            Console.WriteLine("------------------------------------------------");

            calculadora.Encender();

            Console.ReadKey();

            Console.WriteLine("------------------------------------------------");
           
            //2ºclase
            yeaaa.Cerrar();

            Console.WriteLine("------------------------------------------------");

            yeaaa.Minimizar();

            Console.WriteLine("------------------------------------------------");

            yeaaa.Maximizar();

            Console.WriteLine("------------------------------------------------");

            yeaaa.Encender();

            Console.ReadKey();

            //3ºclase
            yeaaa.Cerrar();

            Console.WriteLine("------------------------------------------------");

            yeaaa.Minimizar();

            Console.WriteLine("------------------------------------------------");

            yeaaa.Maximizar();

            Console.WriteLine("------------------------------------------------");

            yeaaa.Encender();

            Console.ReadKey();

        }
    }

    class Ventana
    {
        //atributos
        private int ancho, altura=20;
        private string color = "Rojo";

        //metodos

        public void Cerrar()
        {
            Console.WriteLine("La ventana se cerro!..");
        }

        public void Minimizar()
        {
            Console.WriteLine("la ventana se minimizo!..");
        }

        public void Maximizar()
        {
            Console.WriteLine("La ventana se agrando!..");
        }

        public void Encender()
        {
            Console.WriteLine("La ventana se encendio!..");
        }

        //2ºclase

        class yeaaa
        {
            //atributos
            private int ancho, altura = 20;
            private string color = "Rojo";

            //metodos
            /*
            public void Cerrar2()
            {
                Console.WriteLine("La ventana2 se cerro!..");
            }

            public void Minimizar2()
            {
                Console.WriteLine("la ventana2 se minimizo!..");
            }

            public void Maximizar2()
            {
                Console.WriteLine("La ventana2 se agrando!..");
            }

            public void Encender2()
            {
                Console.WriteLine("La ventana2 se encendio!..");
            }*/
        }
    }


}
