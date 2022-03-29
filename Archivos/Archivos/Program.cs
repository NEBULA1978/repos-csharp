using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  TextWriter archivo;//he creado una variable tipo archivo

              archivo = new StreamWriter("archivo.txt");//hago una instancia y creo archivo txt

              string mensaje;//creo variable string para me guarde cualquier cosa que entre por consola mensaje abajo

              mensaje = Console.ReadLine();//mensaje introduzca se guarda variable mesaje de arriba

              archivo.WriteLine(mensaje);//a archivo llame a su metodo escribir linea y me escriba el contenido de mensaje

              archivo.Close();//que se cierre y no se pierda informacion

              Console.Clear();//que me limpie la pantalla

              Console.WriteLine("Se ha guardado el archivo...");//me imprima en la consola que se guardado el archivo

              TextReader leer_archivo;

              leer_archivo = new StreamReader("archivo.txt");

              Console.WriteLine(leer_archivo.ReadToEnd());

              leer_archivo.Close();
              */

            //con anterior arriba borra frase anterior y escribe la nueva
            //con el de abajo añade frses al archivo de texto
            StreamWriter archivo = File.AppendText("archivo.txt");

            string mensaje;

            mensaje = Console.ReadLine();

            archivo.WriteLine(mensaje);

            archivo.Close();


            Console.ReadKey(); //para parar aplicacion hasta que pulse una tecla e intro y se cierra
        }
    }
}
