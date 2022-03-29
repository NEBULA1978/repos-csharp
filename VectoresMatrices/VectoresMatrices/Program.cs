using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectoresMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglos unidireccional y bidimensional arreglos o matrices
            int[] numero;//vector vacio asignamos en el momentos de crear la instancia

            numero = new int[5];
            //  numero = new int[10]; pasaria de tener 5 a 10, arreglos de forma como objetos

            numero[0] = 5;
            numero[2] = 6;
            numero[4] = 7;

            foreach ( int elemento in numero)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();

        }
    }
}
