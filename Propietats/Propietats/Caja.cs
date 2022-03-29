﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propietats
{
    class Caja
    {
        //miembros variables
        private int largo;
        private int alto;
      //  private int ancho;
        private int volumen;

        //construimos un constructor
        public Caja(int largo, int alto, int ancho)
        {
            this.largo = largo;
            this.alto = alto;
            this.Ancho = ancho;
        }



        public int Volumen { 
            set
            {
                volumen = value;
            }
            get
            {
                return Alto * Ancho * Largo;
            }


                }

        public int Alto { 
            get
            {
                return alto;
            }
           /* set
            {
                if (value < 0) value = -value;//throw new Exception("El tamaño debe ser positivo");
                alto = value;
            }*/


        }


        //propiedad Auto Implementada Prop y 2veces tab
        public int Ancho { get; set; }

       /* public int Largo//propiedades con mayusculas y variables minusculas
        {
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }*///FormatException larga  hacia ariiba corta abajo es lo mismo

        public int Largo
        {
            get => largo;
            set => largo = value;
        }


        //Miembro metodo
        public void MuestraInfo()
        {
            Console.WriteLine("EL largo es {0}. La altura es {1}. El ancho es {2}. Por lo tanto el volumen es {3}"
                , largo, alto, Ancho, volumen = Ancho * alto * largo);
        }

      /*  public void SetLargo(int largo)
        {
            this.largo = largo;
        }

        public int GetLargo()
        {
            return this.largo;
        }
      */
    }
}
