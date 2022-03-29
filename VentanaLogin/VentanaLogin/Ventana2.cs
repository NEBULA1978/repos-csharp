using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaLogin
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 VentanaLogin = new Form1();

            VentanaLogin.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string seleccion;

            if (checkBox1.Checked == true)
            {
                cont++;
            }

            if (checkBox2.Checked == true)
            {
                cont++;
            }

            if (radioButton1.Checked == true)
            {
                seleccion = "Tarjeta de credito";

            }else
            {
                seleccion = "PayPal";
            }

            MessageBox.Show("Ha seleccionado " + cont + " cursos y el metodo de pago es: " + seleccion);


        }
    }
}
