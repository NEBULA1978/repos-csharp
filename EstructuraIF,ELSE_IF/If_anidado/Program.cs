using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_anidado
{
    class Program
    {
        static void Main(string[] args)
        {
            //estructura if

            byte juan = 20, pedro = 19, jorge = 25;

            if (juan > pedro)
            {
                if(jorge > juan)
                {
                    Console.WriteLine("jorge es el mayor de todos");
                }
                Console.ReadKey();
            }
        }
    }
}
