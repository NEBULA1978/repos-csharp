using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYObjetos
{
    class Humano
    {
        //creamos miembro variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;

        //constructor por defecto
        public Humano()
        {
            Console.WriteLine("Constructor llamado. objetoo creado");
        }




        //CONSTRUCTOR MIEMBRO PARAMETRIZADO
        public Humano(string primerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;

        }

        public Humano(string primerNombre, string apellido, string colorOjos)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            

        }

        public Humano(string primerNombre, string apellido)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            

        }

        public Humano(string primerNombre)
        {
            this.primerNombre = primerNombre;
         
        }

        //Miembro metodo
        public void presentarme()
        {
            if (edad !=1 && primerNombre != null && apellido != null && colorOjos != null)
            Console.WriteLine("Hola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3}"
                , primerNombre, apellido, edad, colorOjos);
            else if  (primerNombre != null && apellido != null && colorOjos != null)
                Console.WriteLine("Hola, soy {0} {1}. Mi color de ojos es {2}"
                , primerNombre, apellido , colorOjos);
            else if (primerNombre != null && apellido != null)
                Console.WriteLine("Hola, soy {0} {1}"
                , primerNombre, apellido);
            else if (primerNombre != null)
                Console.WriteLine("Hola, soy {0}"
                , primerNombre, apellido, colorOjos);
        }
    }
}
