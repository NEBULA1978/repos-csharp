using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class FiguraTriangulo : FiguraRectangulo
    {
       public void Area(int Base, int Altura,int radio)
       {
            Console.WriteLine("El area del triangulo es: " + (Base * Altura)* radio / 2);
        }
    }
}
