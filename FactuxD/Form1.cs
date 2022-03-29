using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//utilizar variables de conexiones

namespace FactuxD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {//intenta conectarte a base de datos si todo ha ocurrido bien envia mensaje se ha conectado
                SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
                Con.Open();
                MessageBox.Show("Se ha conectado");
            }
            catch (Exception error)
            {
                MessageBox.Show("ha ocurrido un error:" + error.Message);
            }

            //metodos dataset hacer las consultas y guardarlas 
            //y metodo validar formulario se utilizan para DLL


        }
    }
}
