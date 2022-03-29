using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMudo
{
    class Program
    {
        //const double PI = 3.14159265359;
        //const int semanas = 52, meses = 12;
        //const string nacimiento = "31.05.1978";

        static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un metodo");
            Console.Read();

            //  Console.ForegroundColor = ConsoleColor.Black; color de las letras
            //   Console.BackgroundColor = ConsoleColor.Green; fondo de consola
            //   Console.Clear();
            //   Console.WriteLine("Hola Mundo");
            //   Console.WriteLine("Hola Ramon");
            //   Console.ReadKey();
            //variables integer enteras
            //int num1 = 13;
            //int num2 = 5;
            //int sum = num1 + num2;
            //int num3, num4, num5;
            ////decimales
            //double d1 = 3.2;
            //double d2 = 1.337;
            //double sumd = d1 + num2;


            //  float f1 = 3.5f;

            //  Console.WriteLine(" La suma de " + d1 + " Mas " + num2 + " da como resultado " + sumd);
            //   Console.ReadKey();//pulso y sale el siguiente

            //   Console.WriteLine(" La suma de " + d1 + " Mas " + d2 + " da como resultado " + sumd);
            //   Console.ReadKey();

            //variables string
            //   string MiNombre = "Ramon"; 
            //   string mensaje = " Mi nombre es " + MiNombre;

            //  string MensMin = mensaje.ToLower();//convertir frase en minusculas

            //   Console.WriteLine(MensMin);
            //  Console.Read();

            //Aprende lo Básico de C# - Tutorial Completo para Principiantes
            //(720p_50fps_H264-128kbit_AAC) minuto 50 dura 4h 55'

            //string miString = "15";
            //string miSegundoString = "10";
            //string resultado = miString + miSegundoString;



            //int num1 = Int32.Parse(miString);
            //int num2 = Int32.Parse(miSegundoString);

            //int resultado2 = num1 + num2;

            //Console.WriteLine(resultado2);
            //Console.Read();

            //Console.WriteLine("Mi nacimiento fue el: {0}", nacimiento);
            //Console.Read();
        }

        //estructura de un metodo
        //NivelDeAceso - (static) - TipoDeRetorno - NombreDelMetodo (parametro1, Parametro2)
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo naci de un metodo");
            
            //1h20 minuts del video4h55' ; 25 del 7 2021 ; 1:32am
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }
    }
}
