using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()//constructor
        {
            InitializeComponent();//metodo inicializar los componentes
        }

        private void button1_Click(object sender, EventArgs e)//metodo boton privado 
        {
            this.Close();
        }
    }
}
