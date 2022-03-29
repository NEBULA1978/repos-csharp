using System;

namespace Operadores_asignacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //operadores de asignacion
            byte edad = 20;

            edad = Convert.ToByte(edad + 10);//no puedo sumar diferentes datos int y byte con convert.Tobyte
            //Mucho mas corto operador de asignacion abajo lo mismo frase anterior
            edad += 10;

            Console.WriteLine("Tu edad es : " + edad);

            Console.ReadKey();
        }
    }
}
