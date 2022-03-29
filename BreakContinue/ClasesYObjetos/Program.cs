using System;


namespace ClasesYObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //crea un objeto desde la clase
            //una instancia de humano
            //Humano juan = new Humano();
            ////accediendo a una variable publica externa
            //juan.primerNombre = "Juan";
            ////llamada a un metodo de la clase
            //juan.presentarme();

            //Humano pedro = new Humano();
            //pedro.primerNombre = "Julio";
            //pedro.presentarme();

            //Humano laura = new Humano("Laura","Lopez");
            //Humano franco = new Humano("Franco","Milano");
            ////laura.primerNombre = "Laura";
            ////franco.primerNombre = "Franco";
            ////laura.apellido = "Lopez";
            ////franco.apellido = "Milano";

            //laura.presentarme();
            //franco.presentarme();

            //Humano luis = new Humano("Luis", "Garay", "Marron", 42);
            //Humano ana = new Humano("Ana", "Maina", "verde", 1);

            //luis.presentarme();
            //ana.presentarme();

            //Humano humanoBasico = new Humano("Alberto", "Perez", "Azul");
            //humanoBasico.presentarme();

            Humano natalio = new Humano("Natalio");
            Humano juana = new Humano("Juana", "Garay");
            Humano milena = new Humano("Milena", "Millera");
            Humano Antonio = new Humano("Antonio", "Camilo", "Azul", 7);

            natalio.presentarme();
            juana.presentarme();
            milena.presentarme();
            Antonio.presentarme();

            Console.WriteLine("--------------------------------------------------------------");

            natalio.presentarme();
            juana.presentarme();
            milena.presentarme();
            Antonio.presentarme();


            Console.Read();
        }
    }
}
