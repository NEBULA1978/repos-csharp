using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador < 100;contador++)
            {
                
                if (contador %2 ==0)
                {
                    Console.WriteLine("El proximo es impar");
                continue;
                }
                Console.WriteLine(contador);
            }
            Console.Read();
        }

       
    }
}
