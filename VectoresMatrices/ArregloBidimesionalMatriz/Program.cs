using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloBidimesionalMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglo bidimensional

            int[,] numero;

            numero = new int[3, 3];//he declarado la matriz una instancia de objeto ;le decimos 3filas y 3 columnas

            for (int fila = 0; fila < 3; fila++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Dame un numero: ");
                    numero[fila, col] = Convert.ToInt16(Console.ReadLine());
                }

            }
            Console.Clear();//limpia pantalla despues de cojer los valores


            for (int fila = 0; fila < 3; fila++)//dibuja la matriz lo que es en pantalla
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(" " + numero[fila, col]);
                    
                }
                Console.WriteLine();



                
        }
            Console.ReadKey();
        }
}
}
