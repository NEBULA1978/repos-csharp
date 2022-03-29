using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOLAMUNDO2.CLASES
{
    class CLASEINICIAL
    {
        public static string NOMBRE = "";//delaro variable e inicializo variable global
        [STAThread]
        public static void Main()
        {
            Console.WriteLine("HOLA MUNDO");
            Console.WriteLine("¿Cual es tu nombre?");
          //  string NOMBRE = "";//delaro variable e inicializo LOCAL
            NOMBRE = Console.ReadLine();
            Console.Clear();//limpiar pantalla
            Console.WriteLine("Hola " + NOMBRE);
            Console.ReadKey();//espera a que pulse una letra y cierra
            Console.Clear();
            double A, B, C;
            A = B = C = 0.0;
            Console.WriteLine("TECLEE EL VALOR DE A");
            A =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("TECLEE EL VALOR DE B");
            B = Convert.ToDouble(Console.ReadLine());
            C = A + B;
            Console.WriteLine("La suma de:  " + A + " + " + B + "es:  " + C);
            MessageBox.Show("La suma de:  " + A + " + " + B + "es:  " + C);//caja de mensajes se ve ventanita co texto
            Console.ReadKey();
            FORMULARIOS.FrmPortada PORTADA = new FORMULARIOS.FrmPortada();//creo objeto
            PORTADA.ShowDialog();
        }

}
}
