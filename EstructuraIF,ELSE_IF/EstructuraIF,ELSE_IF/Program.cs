using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraIF_ELSE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //estructura if

            byte juan = 19, pedro = 19;

            if (juan > pedro)
            {
                Console.WriteLine("Juan es mayor que pedro");
            }
            else if (juan < pedro)
            {
                Console.WriteLine("Juan es menor que pedro");
            }

            Console.ReadKey();
        }
    }
}
