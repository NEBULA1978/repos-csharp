using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos instancias de las clases
            FiguraRectangulo rectangulo = new FiguraRectangulo();

            rectangulo.Area(34, 56);

            FiguraTriangulo triangulo = new FiguraTriangulo();

            triangulo.Area(34, 56, 23);

            Console.ReadKey();
        }

    }
}
