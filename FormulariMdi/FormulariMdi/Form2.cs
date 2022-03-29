using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariMdi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //la barra de progreso renemos indicarle 3cosas valor inicial, valor final y los paso que va a ir dando
            //si lo pongo de uno en uno de 5 en 5 ,la barra se lenar mas rapida
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 100;
            progressBar1.Step = 2;

            for (int x= 0; x < 100; x++)
            {
                progressBar1.PerformStep();//metodo para llenar la barra con el for anterior
            }
        }
    }
}
