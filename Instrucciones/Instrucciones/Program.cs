using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//para ver despacio

namespace Instrucciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //break
            for(int id=1; id <= 10; id++ )
            {
                Thread.Sleep(800);//para ver despacio de 1 en 1
                Console.WriteLine(id);
                if (id ==5)
                {
                    break;
                }
            }
            Console.ReadKey();

        }
        
    }
}
