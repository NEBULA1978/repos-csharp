using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;//para ver despacio

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Continue
            for (int id = 1; id <= 10; id++)
            {
                Thread.Sleep(800);//para ver despacio de 1 en 1
                
                if (id == 8)
                {
                    Console.WriteLine();//salto de linea entre el 8 y el 9
                   continue;
                }
                Console.WriteLine(id);
            }
            Console.ReadKey();
        }
}
}
